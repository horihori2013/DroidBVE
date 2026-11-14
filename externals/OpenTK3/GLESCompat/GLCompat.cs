// Desktop OpenGL compatibility shim over OpenGL ES 3.0.
//
// LibRender2 targets the desktop `OpenTK.Graphics.OpenGL` API (OpenGL 3.x/4.x
// style calls plus a little fixed-function for the UI overlays). On Android
// only OpenGL ES is available, so this file re-provides the API surface that
// LibRender2 actually uses on top of the OpenTK.Graphics.ES30 bindings:
//
//   - shader/buffer/texture/FBO/VAO calls map ~1:1 onto ES 3.0
//   - ProgramUniform* (DSA) is emulated with UseProgram + Uniform*
//   - the fixed-function pieces (Begin/Vertex*/End and the matrix stack) are
//     emulated with a small immediate-mode shader and CPU-side matrix stacks
//   - GLSL sources are preprocessed into GLSL ES 1.00 form
//
// Enum values are identical between desktop GL and GL ES, so enums are cast
// by value. The emulation state is only used by the UI/font overlay code.

using System;
using System.Collections.Generic;
using ES = OpenTK.Graphics.ES30;
using GLMatrixMode = OpenTK.Graphics.OpenGL.MatrixMode;

namespace OpenTK.Graphics.OpenGL
{
	public static class GL
	{
		#region Shader / program handling (ProgramUniform* emulation)

		private static int currentProgram;

		public static int CreateShader(ShaderType type)
		{
			int shader = ES.GL.CreateShader((ES.ShaderType)(int)type);
			shaderTypes[shader] = type;
			return shader;
		}

		public static void ShaderSource(int shader, string source)
		{
			ES.GL.ShaderSource(shader, PreprocessShaderSource(shader, source));
		}

		public static void ShaderSource(int shader, int count, string[] source, int[] length)
		{
			string joined = string.Empty;
			for (int i = 0; i < count && i < source.Length; i++)
			{
				joined += source[i];
			}
			ES.GL.ShaderSource(shader, PreprocessShaderSource(shader, joined));
		}

		public static void CompileShader(int shader)
		{
			ES.GL.CompileShader(shader);
		}

		public static void GetShader(int shader, ShaderParameter pname, out int @params)
		{
			ES.GL.GetShader(shader, (ES.ShaderParameter)(int)pname, out @params);
		}

		public static int GetShader(int shader, ShaderParameter pname)
		{
			int result;
			ES.GL.GetShader(shader, (ES.ShaderParameter)(int)pname, out result);
			return result;
		}

		public static string GetShaderInfoLog(int shader)
		{
			return ES.GL.GetShaderInfoLog(shader);
		}

		public static void DeleteShader(int shader)
		{
			ES.GL.DeleteShader(shader);
		}

		public static int CreateProgram()
		{
			return ES.GL.CreateProgram();
		}

		public static void AttachShader(int program, int shader)
		{
			ES.GL.AttachShader(program, shader);
		}

		public static void BindAttribLocation(int program, int index, string name)
		{
			ES.GL.BindAttribLocation(program, index, name);
		}

		public static void BindFragDataLocation(int program, int colorNumber, string name)
		{
			// Not available in OpenGL ES; fragment outputs are bound automatically.
		}

		public static void LinkProgram(int program)
		{
			ES.GL.LinkProgram(program);
		}

		public static void GetProgram(int program, GetProgramParameterName pname, out int @params)
		{
			ES.GL.GetProgram(program, (ES.GetProgramParameterName)(int)pname, out @params);
		}

		public static int GetProgram(int program, GetProgramParameterName pname)
		{
			int result;
			ES.GL.GetProgram(program, (ES.GetProgramParameterName)(int)pname, out result);
			return result;
		}

		public static string GetProgramInfoLog(int program)
		{
			return ES.GL.GetProgramInfoLog(program);
		}

		public static void DeleteProgram(int program)
		{
			if (currentProgram == program)
			{
				currentProgram = 0;
			}
			ES.GL.DeleteProgram(program);
		}

		public static void UseProgram(int program)
		{
			currentProgram = program;
			ES.GL.UseProgram(program);
		}

		public static int GetAttribLocation(int program, string name)
		{
			return ES.GL.GetAttribLocation(program, name);
		}

		public static int GetUniformLocation(int program, string name)
		{
			return ES.GL.GetUniformLocation(program, name);
		}

		public static int GetUniformBlockIndex(int program, string uniformBlockName)
		{
			return ES.GL.GetUniformBlockIndex(program, uniformBlockName);
		}

		public static void UniformBlockBinding(int program, int uniformBlockIndex, int uniformBlockBinding)
		{
			ES.GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
		}

		public static void UniformBlockBinding(int program, uint uniformBlockIndex, int uniformBlockBinding)
		{
			ES.GL.UniformBlockBinding(program, (int)uniformBlockIndex, uniformBlockBinding);
		}

		public static void Uniform1(int location, int x)
		{
			ES.GL.Uniform1(location, x);
		}

		public static void Uniform1(int location, float x)
		{
			ES.GL.Uniform1(location, x);
		}

		public static void Uniform2(int location, float x, float y)
		{
			ES.GL.Uniform2(location, x, y);
		}

		public static void Uniform3(int location, float x, float y, float z)
		{
			ES.GL.Uniform3(location, x, y, z);
		}

		public static void Uniform4(int location, float x, float y, float z, float w)
		{
			ES.GL.Uniform4(location, x, y, z, w);
		}

		public static void UniformMatrix4(int location, int count, bool transpose, ref Matrix4 matrix)
		{
			ES.GL.UniformMatrix4(location, count, transpose, ref matrix.Row0.X);
		}

		public static void UniformMatrix4(int location, bool transpose, ref Matrix4 matrix)
		{
			ES.GL.UniformMatrix4(location, 1, transpose, ref matrix.Row0.X);
		}

		public static unsafe void UniformMatrix4(int location, int count, bool transpose, double* matrix)
		{
			Matrix4 m = ReadMatrix(matrix);
			ES.GL.UniformMatrix4(location, count, transpose, ref m.Row0.X);
		}

		// DSA entry points: emulate by binding the program for the duration of the call.
		public static void ProgramUniform1(int program, int location, int x)
		{
			int previous = currentProgram;
			UseProgram(program);
			Uniform1(location, x);
			UseProgram(previous);
		}

		public static void ProgramUniform1(int program, int location, float x)
		{
			int previous = currentProgram;
			UseProgram(program);
			Uniform1(location, x);
			UseProgram(previous);
		}

		public static void ProgramUniform2(int program, int location, float x, float y)
		{
			int previous = currentProgram;
			UseProgram(program);
			Uniform2(location, x, y);
			UseProgram(previous);
		}

		public static void ProgramUniform3(int program, int location, float x, float y, float z)
		{
			int previous = currentProgram;
			UseProgram(program);
			Uniform3(location, x, y, z);
			UseProgram(previous);
		}

		public static void ProgramUniform4(int program, int location, float x, float y, float z, float w)
		{
			int previous = currentProgram;
			UseProgram(program);
			Uniform4(location, x, y, z, w);
			UseProgram(previous);
		}

		public static void ProgramUniformMatrix4(int program, int location, int count, bool transpose, ref Matrix4 matrix)
		{
			int previous = currentProgram;
			UseProgram(program);
			UniformMatrix4(location, count, transpose, ref matrix);
			UseProgram(previous);
		}

		public static void ProgramUniformMatrix4(int program, int location, bool transpose, ref Matrix4 matrix)
		{
			ProgramUniformMatrix4(program, location, 1, transpose, ref matrix);
		}

		/// <summary>
		/// Converts desktop GLSL (1.20 style) into GLSL ES 1.00, which accepts the
		/// same attribute/varying syntax but requires precision qualifiers.
		/// </summary>
		private static string PreprocessShaderSource(int shader, string source)
		{
			source = source.Replace("#version 120", string.Empty).Replace("#version 130", string.Empty).Replace("#version 140", string.Empty).Replace("#version 150", string.Empty);
			bool fragment = GetShaderType(shader) == ShaderType.FragmentShader;
			string precision = fragment ? "precision mediump float;\nprecision mediump int;\n" : "precision highp float;\nprecision highp int;\n";
			return precision + source;
		}

		private static readonly Dictionary<int, ShaderType> shaderTypes = new Dictionary<int, ShaderType>();

		private static ShaderType GetShaderType(int shader)
		{
			ShaderType type;
			if (shaderTypes.TryGetValue(shader, out type))
			{
				return type;
			}
			return ShaderType.VertexShader;
		}

		#endregion

		#region Buffers / vertex arrays

		public static int GenBuffer()
		{
			int result;
			ES.GL.GenBuffers(1, out result);
			return result;
		}

		public static void GenBuffers(int n, int[] buffers)
		{
			ES.GL.GenBuffers(n, buffers);
		}

		public static void GenBuffers(int n, out int buffers)
		{
			ES.GL.GenBuffers(n, out buffers);
		}

		public static void DeleteBuffer(int buffer)
		{
			ES.GL.DeleteBuffers(1, ref buffer);
		}

		public static void DeleteBuffers(int n, ref int buffers)
		{
			ES.GL.DeleteBuffers(n, ref buffers);
		}

		public static void DeleteBuffers(int n, int[] buffers)
		{
			ES.GL.DeleteBuffers(n, buffers);
		}

		public static void BindBuffer(BufferTarget target, int buffer)
		{
			ES.GL.BindBuffer((ES.BufferTarget)(int)target, buffer);
		}

		public static unsafe void BufferData<T>(BufferTarget target, IntPtr size, T[] data, BufferUsageHint usage) where T : struct
		{
			fixed (T* p = data)
			{
				ES.GL.BufferData((ES.All)(int)target, size, (IntPtr)p, (ES.All)(int)usage);
			}
		}

		public static void BufferData(BufferTarget target, int size, IntPtr data, BufferUsageHint usage)
		{
			ES.GL.BufferData((ES.BufferTarget)(int)target, size, data, (ES.BufferUsageHint)(int)usage);
		}

		public static unsafe void BufferData<T>(BufferTarget target, int size, T[] data, BufferUsageHint usage) where T : struct
		{
			fixed (T* p = data)
			{
				ES.GL.BufferData((ES.BufferTarget)(int)target, size, (IntPtr)p, (ES.BufferUsageHint)(int)usage);
			}
		}

		public static unsafe void BufferData<T>(BufferTarget target, T[] data, BufferUsageHint usage) where T : struct
		{
			fixed (T* p = data)
			{
				ES.GL.BufferData((ES.BufferTarget)(int)target, System.Runtime.InteropServices.Marshal.SizeOf<T>() * data.Length, (IntPtr)p, (ES.BufferUsageHint)(int)usage);
			}
		}

		public static void BufferSubData(BufferTarget target, IntPtr offset, int size, IntPtr data)
		{
			ES.GL.BufferSubData((ES.All)(int)target, offset, size, data);
		}

		public static unsafe void BufferSubData<T>(BufferTarget target, IntPtr offset, int size, T[] data) where T : struct
		{
			fixed (T* p = data)
			{
				ES.GL.BufferSubData((ES.All)(int)target, offset, size, (IntPtr)p);
			}
		}

		public static unsafe void BufferSubData<T>(BufferTarget target, IntPtr offset, IntPtr size, T[] data) where T : struct
		{
			fixed (T* p = data)
			{
				ES.GL.BufferSubData((ES.All)(int)target, offset, size, (IntPtr)p);
			}
		}

		public static void BindBufferBase(BufferTarget target, int index, int buffer)
		{
			ES.GL.BindBufferBase((ES.All)(int)target, index, buffer);
		}

		public static int GenVertexArray()
		{
			int result;
			ES.GL.GenVertexArrays(1, out result);
			return result;
		}

		public static void GenVertexArrays(int n, int[] arrays)
		{
			ES.GL.GenVertexArrays(n, arrays);
		}

		public static void GenVertexArrays(int n, out int arrays)
		{
			ES.GL.GenVertexArrays(n, out arrays);
		}

		public static void DeleteVertexArray(int array)
		{
			ES.GL.DeleteVertexArrays(1, ref array);
		}

		public static void DeleteVertexArrays(int n, ref int arrays)
		{
			ES.GL.DeleteVertexArrays(n, ref arrays);
		}

		public static void BindVertexArray(int array)
		{
			ES.GL.BindVertexArray(array);
		}

		public static void EnableVertexAttribArray(int index)
		{
			ES.GL.EnableVertexAttribArray(index);
		}

		public static void DisableVertexAttribArray(int index)
		{
			ES.GL.DisableVertexAttribArray(index);
		}

		public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
		{
			ES.GL.VertexAttribPointer(index, size, (ES.VertexAttribPointerType)(int)type, normalized, stride, new IntPtr(offset));
		}

		public static void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr offset)
		{
			ES.GL.VertexAttribPointer(index, size, (ES.VertexAttribPointerType)(int)type, normalized, stride, offset);
		}

		public static void VertexAttribIPointer(int index, int size, VertexAttribIntegerType type, int stride, int offset)
		{
			ES.GL.VertexAttribIPointer(index, size, (ES.VertexAttribIntegerType)(int)type, stride, new IntPtr(offset));
		}

		public static void VertexAttribIPointer(int index, int size, VertexAttribIntegerType type, int stride, IntPtr offset)
		{
			ES.GL.VertexAttribIPointer(index, size, (ES.VertexAttribIntegerType)(int)type, stride, offset);
		}

		#endregion

		#region Textures

		public static void ActiveTexture(TextureUnit texture)
		{
			ES.GL.ActiveTexture((ES.TextureUnit)(int)texture);
		}

		public static void BindTexture(TextureTarget target, int texture)
		{
			if (target == TextureTarget.Texture2D)
			{
				boundTexture2D = texture;
			}
			ES.GL.BindTexture((ES.TextureTarget)(int)target, texture);
		}

		public static int GenTexture()
		{
			int result;
			ES.GL.GenTextures(1, out result);
			return result;
		}

		public static void GenTextures(int n, int[] textures)
		{
			ES.GL.GenTextures(n, textures);
		}

		public static void GenTextures(int n, out int textures)
		{
			ES.GL.GenTextures(n, out textures);
		}

		public static void DeleteTexture(int texture)
		{
			ES.GL.DeleteTextures(1, ref texture);
		}

		public static void DeleteTextures(int n, ref int textures)
		{
			ES.GL.DeleteTextures(n, ref textures);
		}

		public static void DeleteTextures(int n, int[] textures)
		{
			ES.GL.DeleteTextures(n, textures);
		}

		public static void TexParameter(TextureTarget target, TextureParameterName pname, int param)
		{
			ES.GL.TexParameter((ES.TextureTarget)(int)target, (ES.TextureParameterName)(int)pname, param);
		}

		public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
		{
			ES.GL.TexParameter((ES.TextureTarget)(int)target, (ES.TextureParameterName)(int)pname, param);
		}

		public static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
		{
			ES.GL.TexParameter((ES.All)(int)target, (ES.All)(int)pname, @params);
		}

		public static void TexParameter(TextureTarget target, TextureParameterName pname, int[] @params)
		{
			ES.GL.TexParameter((ES.All)(int)target, (ES.All)(int)pname, @params);
		}

		public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			ES.GL.TexImage2D((ES.All)(int)target, level, (ES.All)(int)internalformat, width, height, border, (ES.All)(int)format, (ES.All)(int)type, pixels);
		}

		public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			ES.GL.TexImage2D((ES.All)(int)target, level, (ES.All)(int)internalformat, width, height, border, (ES.All)(int)format, (ES.All)(int)type, pixels);
		}

		public static void TexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, byte[] pixels)
		{
			ES.GL.TexImage2D((ES.All)(int)target, level, (ES.All)(int)internalformat, width, height, border, (ES.All)(int)format, (ES.All)(int)type, pixels);
		}

		public static void TexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, PixelFormat format, PixelType type, byte[] pixels)
		{
			ES.GL.TexImage2D((ES.All)(int)target, level, (ES.All)(int)internalformat, width, height, border, (ES.All)(int)format, (ES.All)(int)type, pixels);
		}

		public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			ES.GL.TexSubImage2D((ES.All)(int)target, level, xoffset, yoffset, width, height, (ES.All)(int)format, (ES.All)(int)type, pixels);
		}

		public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, byte[] pixels)
		{
			ES.GL.TexSubImage2D((ES.All)(int)target, level, xoffset, yoffset, width, height, (ES.All)(int)format, (ES.All)(int)type, pixels);
		}

		public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			ES.GL.CopyTexImage2D((ES.All)(int)target, level, (ES.All)(int)internalformat, x, y, width, height, border);
		}

		public static void CopyTexImage2D(TextureTarget target, int level, PixelInternalFormat internalformat, int x, int y, int width, int height, int border)
		{
			ES.GL.CopyTexImage2D((ES.All)(int)target, level, (ES.All)(int)internalformat, x, y, width, height, border);
		}

		public static void GenerateMipmap(GenerateMipmapTarget target)
		{
			ES.GL.GenerateMipmap((ES.All)(int)target);
		}

		#endregion

		#region Framebuffers

		public static int GenFramebuffer()
		{
			int result;
			ES.GL.GenFramebuffers(1, out result);
			return result;
		}

		public static void GenFramebuffers(int n, int[] framebuffers)
		{
			ES.GL.GenFramebuffers(n, framebuffers);
		}

		public static void GenFramebuffers(int n, out int framebuffers)
		{
			ES.GL.GenFramebuffers(n, out framebuffers);
		}

		public static void DeleteFramebuffer(int framebuffer)
		{
			ES.GL.DeleteFramebuffers(1, ref framebuffer);
		}

		public static void DeleteFramebuffers(int n, int[] framebuffers)
		{
			ES.GL.DeleteFramebuffers(n, framebuffers);
		}

		public static int GenRenderbuffer()
		{
			int result;
			ES.GL.GenRenderbuffers(1, out result);
			return result;
		}

		public static void GenRenderbuffers(int n, int[] renderbuffers)
		{
			ES.GL.GenRenderbuffers(n, renderbuffers);
		}

		public static void GenRenderbuffers(int n, out int renderbuffers)
		{
			ES.GL.GenRenderbuffers(n, out renderbuffers);
		}

		public static void DeleteRenderbuffer(int renderbuffer)
		{
			ES.GL.DeleteRenderbuffers(1, ref renderbuffer);
		}

		public static void DeleteRenderbuffers(int n, int[] renderbuffers)
		{
			ES.GL.DeleteRenderbuffers(n, renderbuffers);
		}

		public static void BindFramebuffer(FramebufferTarget target, int framebuffer)
		{
			ES.GL.BindFramebuffer((ES.FramebufferTarget)(int)target, framebuffer);
		}

		public static void BindRenderbuffer(RenderbufferTarget target, int renderbuffer)
		{
			ES.GL.BindRenderbuffer((ES.RenderbufferTarget)(int)target, renderbuffer);
		}

		public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, int texture, int level)
		{
			ES.GL.FramebufferTexture2D((ES.All)(int)target, (ES.All)(int)attachment, (ES.All)(int)textarget, texture, level);
		}

		public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, int renderbuffer)
		{
			ES.GL.FramebufferRenderbuffer((ES.FramebufferTarget)(int)target, (ES.FramebufferAttachment)(int)attachment, (ES.RenderbufferTarget)(int)renderbuffertarget, renderbuffer);
		}

		public static FramebufferErrorCode CheckFramebufferStatus(FramebufferTarget target)
		{
			return (FramebufferErrorCode)(int)ES.GL.CheckFramebufferStatus((ES.FramebufferTarget)(int)target);
		}

		public static void RenderbufferStorage(RenderbufferTarget target, RenderbufferStorage internalformat, int width, int height)
		{
			ES.GL.RenderbufferStorage((ES.All)(int)target, (ES.All)(int)internalformat, width, height);
		}

		public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
		{
			ES.GL.RenderbufferStorage((ES.All)(int)target, (ES.All)(int)internalformat, width, height);
		}

		public static void RenderbufferStorage(RenderbufferTarget target, PixelInternalFormat internalformat, int width, int height)
		{
			ES.GL.RenderbufferStorage((ES.All)(int)target, (ES.All)(int)internalformat, width, height);
		}

		public static void DrawBuffer(DrawBufferMode mode)
		{
			ES.GL.DrawBuffers(1, new[] { (ES.DrawBufferMode)(int)mode });
		}

		public static void DrawBuffers(int n, DrawBufferMode[] bufs)
		{
			ES.DrawBufferMode[] modes = new ES.DrawBufferMode[n];
			for (int i = 0; i < n && i < bufs.Length; i++)
			{
				modes[i] = (ES.DrawBufferMode)(int)bufs[i];
			}
			ES.GL.DrawBuffers(n, modes);
		}

		public static void DrawBuffers(int n, DrawBuffersEnum[] bufs)
		{
			ES.DrawBufferMode[] modes = new ES.DrawBufferMode[n];
			for (int i = 0; i < n && i < bufs.Length; i++)
			{
				modes[i] = (ES.DrawBufferMode)(int)bufs[i];
			}
			ES.GL.DrawBuffers(n, modes);
		}

		public static void ReadBuffer(ReadBufferMode mode)
		{
			ES.GL.ReadBuffer((ES.ReadBufferMode)(int)mode);
		}

		#endregion

		#region State

		public static void Enable(EnableCap cap)
		{
			if (cap == EnableCap.Texture2D)
			{
				texture2DEnabled = true;
				return;
			}
			if (cap == EnableCap.AlphaTest)
			{
				alphaTestEnabled = true;
				return;
			}
			ES.GL.Enable((ES.EnableCap)(int)cap);
		}

		public static void Disable(EnableCap cap)
		{
			if (cap == EnableCap.Texture2D)
			{
				texture2DEnabled = false;
				return;
			}
			if (cap == EnableCap.AlphaTest)
			{
				alphaTestEnabled = false;
				return;
			}
			ES.GL.Disable((ES.EnableCap)(int)cap);
		}

		public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
		{
			ES.GL.BlendFunc((ES.All)(int)sfactor, (ES.All)(int)dfactor);
		}

		public static void Clear(ClearBufferMask mask)
		{
			ES.GL.Clear((ES.ClearBufferMask)(int)mask);
		}

		public static void ClearColor(float red, float green, float blue, float alpha)
		{
			ES.GL.ClearColor(red, green, blue, alpha);
		}

		public static void CullFace(CullFaceMode mode)
		{
			ES.GL.CullFace((ES.CullFaceMode)(int)mode);
		}

		public static void DepthFunc(DepthFunction func)
		{
			ES.GL.DepthFunc((ES.DepthFunction)(int)func);
		}

		public static void DepthMask(bool flag)
		{
			ES.GL.DepthMask(flag);
		}

		public static void LineWidth(float width)
		{
			ES.GL.LineWidth(width);
		}

		public static void Viewport(int x, int y, int width, int height)
		{
			ES.GL.Viewport(x, y, width, height);
		}

		public static void Viewport(System.Drawing.Rectangle rectangle)
		{
			ES.GL.Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
		}

		public static void Hint(HintTarget target, HintMode mode)
		{
			ES.GL.Hint((ES.HintTarget)(int)target, (ES.HintMode)(int)mode);
		}

		public static void PixelStore(PixelStoreParameter pname, int param)
		{
			ES.GL.PixelStore((ES.PixelStoreParameter)(int)pname, param);
		}

		public static void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			// Not available in OpenGL ES; solid fill only.
		}

		public static ErrorCode GetError()
		{
			return (ErrorCode)(int)ES.GL.GetError();
		}

		public static string GetString(StringName name)
		{
			return ES.GL.GetString((ES.StringName)(int)name);
		}

		public static float GetFloat(GetPName pname)
		{
			float result;
			ES.GL.GetFloat((ES.GetPName)(int)pname, out result);
			return result;
		}

		public static void GetFloat(GetPName pname, out float data)
		{
			ES.GL.GetFloat((ES.GetPName)(int)pname, out data);
		}

		public static void GetFloat(GetPName pname, float[] data)
		{
			ES.GL.GetFloat((ES.GetPName)(int)pname, data);
		}

		#endregion

		#region Drawing

		public static void DrawArrays(PrimitiveType mode, int first, int count)
		{
			ES.GL.DrawArrays((ES.PrimitiveType)(int)mode, first, count);
		}

		public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, int indices)
		{
			ES.GL.DrawElements((ES.PrimitiveType)(int)mode, count, (ES.DrawElementsType)(int)type, new IntPtr(indices));
		}

		public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices)
		{
			ES.GL.DrawElements((ES.PrimitiveType)(int)mode, count, (ES.DrawElementsType)(int)type, indices);
		}

		#endregion

		#region Fixed-function emulation: matrix stack

		private static GLMatrixMode matrixMode = GLMatrixMode.Modelview;
		private static readonly Stack<double[]> modelviewStack = new Stack<double[]>();
		private static readonly Stack<double[]> projectionStack = new Stack<double[]>();
		private static readonly Stack<double[]> textureStack = new Stack<double[]>();
		private static double[] modelviewMatrix = IdentityMatrix();
		private static double[] projectionMatrix = IdentityMatrix();
		private static double[] textureMatrix = IdentityMatrix();

		public static void MatrixMode(MatrixMode mode)
		{
			matrixMode = mode;
		}

		public static void LoadIdentity()
		{
			SetCurrentMatrix(IdentityMatrix());
		}

		public static unsafe void LoadMatrix(double* m)
		{
			double[] matrix = new double[16];
			for (int i = 0; i < 16; i++)
			{
				matrix[i] = m[i];
			}
			SetCurrentMatrix(matrix);
		}

		public static void LoadMatrix(ref Matrix4 matrix)
		{
			SetCurrentMatrix(new double[]
			{
				matrix.Row0.X, matrix.Row0.Y, matrix.Row0.Z, matrix.Row0.W,
				matrix.Row1.X, matrix.Row1.Y, matrix.Row1.Z, matrix.Row1.W,
				matrix.Row2.X, matrix.Row2.Y, matrix.Row2.Z, matrix.Row2.W,
				matrix.Row3.X, matrix.Row3.Y, matrix.Row3.Z, matrix.Row3.W
			});
		}

		public static void LoadMatrix(ref Matrix4d matrix)
		{
			SetCurrentMatrix(new double[]
			{
				matrix.Row0.X, matrix.Row0.Y, matrix.Row0.Z, matrix.Row0.W,
				matrix.Row1.X, matrix.Row1.Y, matrix.Row1.Z, matrix.Row1.W,
				matrix.Row2.X, matrix.Row2.Y, matrix.Row2.Z, matrix.Row2.W,
				matrix.Row3.X, matrix.Row3.Y, matrix.Row3.Z, matrix.Row3.W
			});
		}

		public static void PushMatrix()
		{
			switch (matrixMode)
			{
				case GLMatrixMode.Projection:
					projectionStack.Push((double[])projectionMatrix.Clone());
					break;
				case GLMatrixMode.Texture:
					textureStack.Push((double[])textureMatrix.Clone());
					break;
				default:
					modelviewStack.Push((double[])modelviewMatrix.Clone());
					break;
			}
		}

		public static void PopMatrix()
		{
			switch (matrixMode)
			{
				case GLMatrixMode.Projection:
					if (projectionStack.Count > 0)
					{
						projectionMatrix = projectionStack.Pop();
					}
					break;
				case GLMatrixMode.Texture:
					if (textureStack.Count > 0)
					{
						textureMatrix = textureStack.Pop();
					}
					break;
				default:
					if (modelviewStack.Count > 0)
					{
						modelviewMatrix = modelviewStack.Pop();
					}
					break;
			}
		}

		public static void Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			double[] ortho = IdentityMatrix();
			ortho[0] = 2.0 / (right - left);
			ortho[5] = 2.0 / (top - bottom);
			ortho[10] = -2.0 / (zFar - zNear);
			ortho[12] = -(right + left) / (right - left);
			ortho[13] = -(top + bottom) / (top - bottom);
			ortho[14] = -(zFar + zNear) / (zFar - zNear);
			SetCurrentMatrix(Multiply(GetCurrentMatrix(), ortho));
		}

		public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Ortho((float)left, (float)right, (float)bottom, (float)top, (float)zNear, (float)zFar);
		}

		private static void SetCurrentMatrix(double[] matrix)
		{
			switch (matrixMode)
			{
				case GLMatrixMode.Projection:
					projectionMatrix = matrix;
					break;
				case GLMatrixMode.Texture:
					textureMatrix = matrix;
					break;
				default:
					modelviewMatrix = matrix;
					break;
			}
		}

		private static double[] GetCurrentMatrix()
		{
			switch (matrixMode)
			{
				case GLMatrixMode.Projection:
					return projectionMatrix;
				case GLMatrixMode.Texture:
					return textureMatrix;
				default:
					return modelviewMatrix;
			}
		}

		private static double[] IdentityMatrix()
		{
			return new[] { 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 1.0 };
		}

		// Column-major matrix product, matching glMultMatrix conventions.
		private static double[] Multiply(double[] a, double[] b)
		{
			double[] r = new double[16];
			for (int col = 0; col < 4; col++)
			{
				for (int row = 0; row < 4; row++)
				{
					double sum = 0.0;
					for (int k = 0; k < 4; k++)
					{
						sum += a[k * 4 + row] * b[col * 4 + k];
					}
					r[col * 4 + row] = sum;
				}
			}
			return r;
		}

		private static unsafe Matrix4 ReadMatrix(double* m)
		{
			return new Matrix4(
				new Vector4((float)m[0], (float)m[1], (float)m[2], (float)m[3]),
				new Vector4((float)m[4], (float)m[5], (float)m[6], (float)m[7]),
				new Vector4((float)m[8], (float)m[9], (float)m[10], (float)m[11]),
				new Vector4((float)m[12], (float)m[13], (float)m[14], (float)m[15]));
		}

		#endregion

		#region Fixed-function emulation: immediate mode

		private struct ImmediateVertex
		{
			public float X, Y, Z;
			public float S, T;
			public float R, G, B, A;
		}

		private static readonly List<ImmediateVertex> immediateVertices = new List<ImmediateVertex>();
		private static PrimitiveType immediateMode;
		private static bool immediateActive;
		private static float currentR = 1.0f, currentG = 1.0f, currentB = 1.0f, currentA = 1.0f;
		private static float currentS, currentT;
		private static bool texture2DEnabled;
		private static bool alphaTestEnabled;
		private static int boundTexture2D;
		private static int immediateProgram;
		private static int immediateVertexShader;
		private static int immediateFragmentShader;
		private static int immediatePosAttrib = -1, immediateTexAttrib = -1, immediateColorAttrib = -1;
		private static int immediateMvpUniform = -1, immediateTexMatrixUniform = -1, immediateUseTextureUniform = -1, immediateSamplerUniform = -1;
		private static int immediateBuffer;

		public static void Begin(PrimitiveType mode)
		{
			immediateActive = true;
			immediateMode = mode;
			immediateVertices.Clear();
		}

		public static void Vertex2(float x, float y)
		{
			AddImmediateVertex(x, y, 0.0f);
		}

		public static void Vertex2(double x, double y)
		{
			AddImmediateVertex((float)x, (float)y, 0.0f);
		}

		public static void Vertex3(float x, float y, float z)
		{
			AddImmediateVertex(x, y, z);
		}

		public static void Vertex3(double x, double y, double z)
		{
			AddImmediateVertex((float)x, (float)y, (float)z);
		}

		public static void TexCoord2(float s, float t)
		{
			currentS = s;
			currentT = t;
		}

		public static void TexCoord2(double s, double t)
		{
			currentS = (float)s;
			currentT = (float)t;
		}

		public static void Color3(float r, float g, float b)
		{
			currentR = r;
			currentG = g;
			currentB = b;
			currentA = 1.0f;
		}

		public static void Color3(double r, double g, double b)
		{
			Color3((float)r, (float)g, (float)b);
		}

		public static void Color3(byte r, byte g, byte b)
		{
			currentR = r / 255.0f;
			currentG = g / 255.0f;
			currentB = b / 255.0f;
			currentA = 1.0f;
		}

		public static void Color4(float r, float g, float b, float a)
		{
			currentR = r;
			currentG = g;
			currentB = b;
			currentA = a;
		}

		public static void Color4(double r, double g, double b, double a)
		{
			Color4((float)r, (float)g, (float)b, (float)a);
		}

		public static void Color4(byte r, byte g, byte b, byte a)
		{
			currentR = r / 255.0f;
			currentG = g / 255.0f;
			currentB = b / 255.0f;
			currentA = a / 255.0f;
		}

		public static void Color4(Color4 color)
		{
			currentR = color.R;
			currentG = color.G;
			currentB = color.B;
			currentA = color.A;
		}

		public static void End()
		{
			immediateActive = false;
			FlushImmediateBuffer();
		}

		private static void AddImmediateVertex(float x, float y, float z)
		{
			ImmediateVertex vertex = new ImmediateVertex
			{
				X = x,
				Y = y,
				Z = z,
				S = currentS,
				T = currentT,
				R = currentR,
				G = currentG,
				B = currentB,
				A = currentA
			};
			immediateVertices.Add(vertex);
		}

		private static void FlushImmediateBuffer()
		{
			if (immediateVertices.Count == 0)
			{
				return;
			}
			EnsureImmediateProgram();

			// Triangulate the few primitive types LibRender2 uses.
			List<ImmediateVertex> drawList = new List<ImmediateVertex>();
			switch (immediateMode)
			{
				case PrimitiveType.Quads:
					for (int i = 0; i + 3 < immediateVertices.Count; i += 4)
					{
						drawList.Add(immediateVertices[i]);
						drawList.Add(immediateVertices[i + 1]);
						drawList.Add(immediateVertices[i + 2]);
						drawList.Add(immediateVertices[i]);
						drawList.Add(immediateVertices[i + 2]);
						drawList.Add(immediateVertices[i + 3]);
					}
					break;
				case PrimitiveType.Polygon:
				case PrimitiveType.TriangleFan:
					for (int i = 1; i + 1 < immediateVertices.Count; i++)
					{
						drawList.Add(immediateVertices[0]);
						drawList.Add(immediateVertices[i]);
						drawList.Add(immediateVertices[i + 1]);
					}
					break;
				case PrimitiveType.LineLoop:
					drawList.AddRange(immediateVertices);
					drawList.Add(immediateVertices[0]);
					break;
				default:
					// Points, Lines, LineStrip, Triangles, TriangleStrip map directly.
					drawList.AddRange(immediateVertices);
					break;
			}

			// Upload vertex data (pos3, tex2, color4 interleaved).
			float[] data = new float[drawList.Count * 9];
			for (int i = 0; i < drawList.Count; i++)
			{
				int o = i * 9;
				ImmediateVertex v = drawList[i];
				data[o] = v.X;
				data[o + 1] = v.Y;
				data[o + 2] = v.Z;
				data[o + 3] = v.S;
				data[o + 4] = v.T;
				data[o + 5] = v.R;
				data[o + 6] = v.G;
				data[o + 7] = v.B;
				data[o + 8] = v.A;
			}

			ES.GL.UseProgram(immediateProgram);
			if (immediateBuffer == 0)
			{
				ES.GL.GenBuffers(1, out immediateBuffer);
			}
			ES.GL.BindBuffer(ES.BufferTarget.ArrayBuffer, immediateBuffer);
			ES.GL.BufferData(ES.BufferTarget.ArrayBuffer, data.Length * sizeof(float), data, ES.BufferUsageHint.StreamDraw);

			int stride = 9 * sizeof(float);
			ES.GL.EnableVertexAttribArray(immediatePosAttrib);
			ES.GL.VertexAttribPointer(immediatePosAttrib, 3, ES.VertexAttribPointerType.Float, false, stride, IntPtr.Zero);
			ES.GL.EnableVertexAttribArray(immediateTexAttrib);
			ES.GL.VertexAttribPointer(immediateTexAttrib, 2, ES.VertexAttribPointerType.Float, false, stride, new IntPtr(3 * sizeof(float)));
			ES.GL.EnableVertexAttribArray(immediateColorAttrib);
			ES.GL.VertexAttribPointer(immediateColorAttrib, 4, ES.VertexAttribPointerType.Float, false, stride, new IntPtr(5 * sizeof(float)));

			// Modelview-projection, matching the desktop fixed-function convention.
			Matrix4 mvp = ToMatrix4(Multiply(projectionMatrix, modelviewMatrix));
			ES.GL.UniformMatrix4(immediateMvpUniform, 1, false, ref mvp.Row0.X);
			Matrix4 texMatrix = ToMatrix4(textureMatrix);
			ES.GL.UniformMatrix4(immediateTexMatrixUniform, 1, false, ref texMatrix.Row0.X);
			ES.GL.Uniform1(immediateUseTextureUniform, texture2DEnabled && boundTexture2D != 0 ? 1.0f : 0.0f);
			if (texture2DEnabled && boundTexture2D != 0)
			{
				ES.GL.ActiveTexture(ES.TextureUnit.Texture0);
				ES.GL.BindTexture(ES.TextureTarget.Texture2D, boundTexture2D);
				ES.GL.Uniform1(immediateSamplerUniform, 0);
			}

			PrimitiveType drawMode = immediateMode == PrimitiveType.Quads || immediateMode == PrimitiveType.Polygon || immediateMode == PrimitiveType.TriangleFan ? PrimitiveType.Triangles : immediateMode;
			ES.GL.DrawArrays((ES.PrimitiveType)(int)drawMode, 0, drawList.Count);

			// Restore program state (LibRender2 rebinds shaders around overlay draws).
			ES.GL.UseProgram(currentProgram);
		}

		private static Matrix4 ToMatrix4(double[] m)
		{
			return new Matrix4(
				new Vector4((float)m[0], (float)m[1], (float)m[2], (float)m[3]),
				new Vector4((float)m[4], (float)m[5], (float)m[6], (float)m[7]),
				new Vector4((float)m[8], (float)m[9], (float)m[10], (float)m[11]),
				new Vector4((float)m[12], (float)m[13], (float)m[14], (float)m[15]));
		}

		private static void EnsureImmediateProgram()
		{
			if (immediateProgram != 0)
			{
				return;
			}

			const string vertexSource =
				"attribute vec3 a_pos;\n" +
				"attribute vec2 a_tex;\n" +
				"attribute vec4 a_color;\n" +
				"uniform mat4 u_mvp;\n" +
				"uniform mat4 u_texMatrix;\n" +
				"varying vec2 v_tex;\n" +
				"varying vec4 v_color;\n" +
				"void main() {\n" +
				"    v_tex = (u_texMatrix * vec4(a_tex, 0.0, 1.0)).st;\n" +
				"    v_color = a_color;\n" +
				"    gl_Position = u_mvp * vec4(a_pos, 1.0);\n" +
				"}\n";

			const string fragmentSource =
				"precision mediump float;\n" +
				"uniform sampler2D u_sampler;\n" +
				"uniform float u_useTexture;\n" +
				"varying vec2 v_tex;\n" +
				"varying vec4 v_color;\n" +
				"void main() {\n" +
				"    vec4 color = v_color;\n" +
				"    if (u_useTexture > 0.5) {\n" +
				"        color *= texture2D(u_sampler, v_tex);\n" +
				"    }\n" +
				"    gl_FragColor = color;\n" +
				"}\n";

			immediateVertexShader = ES.GL.CreateShader(ES.ShaderType.VertexShader);
			ES.GL.ShaderSource(immediateVertexShader, vertexSource);
			ES.GL.CompileShader(immediateVertexShader);
			immediateFragmentShader = ES.GL.CreateShader(ES.ShaderType.FragmentShader);
			ES.GL.ShaderSource(immediateFragmentShader, fragmentSource);
			ES.GL.CompileShader(immediateFragmentShader);
			immediateProgram = ES.GL.CreateProgram();
			ES.GL.AttachShader(immediateProgram, immediateVertexShader);
			ES.GL.AttachShader(immediateProgram, immediateFragmentShader);
			ES.GL.BindAttribLocation(immediateProgram, 0, "a_pos");
			ES.GL.BindAttribLocation(immediateProgram, 1, "a_tex");
			ES.GL.BindAttribLocation(immediateProgram, 2, "a_color");
			ES.GL.LinkProgram(immediateProgram);
			immediatePosAttrib = ES.GL.GetAttribLocation(immediateProgram, "a_pos");
			immediateTexAttrib = ES.GL.GetAttribLocation(immediateProgram, "a_tex");
			immediateColorAttrib = ES.GL.GetAttribLocation(immediateProgram, "a_color");
			immediateMvpUniform = ES.GL.GetUniformLocation(immediateProgram, "u_mvp");
			immediateTexMatrixUniform = ES.GL.GetUniformLocation(immediateProgram, "u_texMatrix");
			immediateUseTextureUniform = ES.GL.GetUniformLocation(immediateProgram, "u_useTexture");
			immediateSamplerUniform = ES.GL.GetUniformLocation(immediateProgram, "u_sampler");
		}

		#endregion
	}
}