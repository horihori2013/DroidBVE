// Extracted from the generated Graphics/OpenGL/GLEnums.cs (desktop OpenGL
// enums). The GLES compatibility shim needs these with their desktop names
// and values; they are mapped to the OpenTK.Graphics.ES30 enums by value.
//
// The 'All' and 'GetPName' enums are minimal subsets used by LibRender2.

using System;

namespace OpenTK.Graphics.OpenGL
{
    public enum AlphaFunction : int
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
    }
    public enum BlendingFactor : int
    {
        /// <summary>
        /// Original was GL_ZERO = 0
        /// </summary>
        Zero = ((int)0),
        /// <summary>
        /// Original was GL_SRC_COLOR = 0x0300
        /// </summary>
        SrcColor = ((int)0x0300),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_COLOR = 0x0301
        /// </summary>
        OneMinusSrcColor = ((int)0x0301),
        /// <summary>
        /// Original was GL_SRC_ALPHA = 0x0302
        /// </summary>
        SrcAlpha = ((int)0x0302),
        /// <summary>
        /// Original was GL_ONE_MINUS_SRC_ALPHA = 0x0303
        /// </summary>
        OneMinusSrcAlpha = ((int)0x0303),
        /// <summary>
        /// Original was GL_DST_ALPHA = 0x0304
        /// </summary>
        DstAlpha = ((int)0x0304),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_ALPHA = 0x0305
        /// </summary>
        OneMinusDstAlpha = ((int)0x0305),
        /// <summary>
        /// Original was GL_DST_COLOR = 0x0306
        /// </summary>
        DstColor = ((int)0x0306),
        /// <summary>
        /// Original was GL_ONE_MINUS_DST_COLOR = 0x0307
        /// </summary>
        OneMinusDstColor = ((int)0x0307),
        /// <summary>
        /// Original was GL_SRC_ALPHA_SATURATE = 0x0308
        /// </summary>
        SrcAlphaSaturate = ((int)0x0308),
        /// <summary>
        /// Original was GL_CONSTANT_COLOR = 0x8001
        /// </summary>
        ConstantColor = ((int)0x8001),
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_COLOR = 0x8002
        /// </summary>
        OneMinusConstantColor = ((int)0x8002),
        /// <summary>
        /// Original was GL_CONSTANT_ALPHA = 0x8003
        /// </summary>
        ConstantAlpha = ((int)0x8003),
        /// <summary>
        /// Original was GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004
        /// </summary>
        OneMinusConstantAlpha = ((int)0x8004),
        /// <summary>
        /// Original was GL_SRC1_ALPHA = 0x8589
        /// </summary>
        Src1Alpha = ((int)0x8589),
        /// <summary>
        /// Original was GL_SRC1_COLOR = 0x88F9
        /// </summary>
        Src1Color = ((int)0x88F9),
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1),
    }
    public enum BufferTarget : int
    {
        /// <summary>
        /// Original was GL_PARAMETER_BUFFER = 0x80EE
        /// </summary>
        ParameterBuffer = ((int)0x80EE),
        /// <summary>
        /// Original was GL_ARRAY_BUFFER = 0x8892
        /// </summary>
        ArrayBuffer = ((int)0x8892),
        /// <summary>
        /// Original was GL_ELEMENT_ARRAY_BUFFER = 0x8893
        /// </summary>
        ElementArrayBuffer = ((int)0x8893),
        /// <summary>
        /// Original was GL_PIXEL_PACK_BUFFER = 0x88EB
        /// </summary>
        PixelPackBuffer = ((int)0x88EB),
        /// <summary>
        /// Original was GL_PIXEL_UNPACK_BUFFER = 0x88EC
        /// </summary>
        PixelUnpackBuffer = ((int)0x88EC),
        /// <summary>
        /// Original was GL_UNIFORM_BUFFER = 0x8A11
        /// </summary>
        UniformBuffer = ((int)0x8A11),
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = ((int)0x8C2A),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER = 0x8C8E
        /// </summary>
        TransformFeedbackBuffer = ((int)0x8C8E),
        /// <summary>
        /// Original was GL_COPY_READ_BUFFER = 0x8F36
        /// </summary>
        CopyReadBuffer = ((int)0x8F36),
        /// <summary>
        /// Original was GL_COPY_WRITE_BUFFER = 0x8F37
        /// </summary>
        CopyWriteBuffer = ((int)0x8F37),
        /// <summary>
        /// Original was GL_DRAW_INDIRECT_BUFFER = 0x8F3F
        /// </summary>
        DrawIndirectBuffer = ((int)0x8F3F),
        /// <summary>
        /// Original was GL_SHADER_STORAGE_BUFFER = 0x90D2
        /// </summary>
        ShaderStorageBuffer = ((int)0x90D2),
        /// <summary>
        /// Original was GL_DISPATCH_INDIRECT_BUFFER = 0x90EE
        /// </summary>
        DispatchIndirectBuffer = ((int)0x90EE),
        /// <summary>
        /// Original was GL_QUERY_BUFFER = 0x9192
        /// </summary>
        QueryBuffer = ((int)0x9192),
        /// <summary>
        /// Original was GL_ATOMIC_COUNTER_BUFFER = 0x92C0
        /// </summary>
        AtomicCounterBuffer = ((int)0x92C0),
    }
    public enum BufferUsageHint : int
    {
        /// <summary>
        /// Original was GL_STREAM_DRAW = 0x88E0
        /// </summary>
        StreamDraw = ((int)0x88E0),
        /// <summary>
        /// Original was GL_STREAM_READ = 0x88E1
        /// </summary>
        StreamRead = ((int)0x88E1),
        /// <summary>
        /// Original was GL_STREAM_COPY = 0x88E2
        /// </summary>
        StreamCopy = ((int)0x88E2),
        /// <summary>
        /// Original was GL_STATIC_DRAW = 0x88E4
        /// </summary>
        StaticDraw = ((int)0x88E4),
        /// <summary>
        /// Original was GL_STATIC_READ = 0x88E5
        /// </summary>
        StaticRead = ((int)0x88E5),
        /// <summary>
        /// Original was GL_STATIC_COPY = 0x88E6
        /// </summary>
        StaticCopy = ((int)0x88E6),
        /// <summary>
        /// Original was GL_DYNAMIC_DRAW = 0x88E8
        /// </summary>
        DynamicDraw = ((int)0x88E8),
        /// <summary>
        /// Original was GL_DYNAMIC_READ = 0x88E9
        /// </summary>
        DynamicRead = ((int)0x88E9),
        /// <summary>
        /// Original was GL_DYNAMIC_COPY = 0x88EA
        /// </summary>
        DynamicCopy = ((int)0x88EA),
    }
    [Flags]
    public enum ClearBufferMask : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_DEPTH_BUFFER_BIT = 0x00000100
        /// </summary>
        DepthBufferBit = ((int)0x00000100),
        /// <summary>
        /// Original was GL_ACCUM_BUFFER_BIT = 0x00000200
        /// </summary>
        AccumBufferBit = ((int)0x00000200),
        /// <summary>
        /// Original was GL_STENCIL_BUFFER_BIT = 0x00000400
        /// </summary>
        StencilBufferBit = ((int)0x00000400),
        /// <summary>
        /// Original was GL_COLOR_BUFFER_BIT = 0x00004000
        /// </summary>
        ColorBufferBit = ((int)0x00004000),
        /// <summary>
        /// Original was GL_COVERAGE_BUFFER_BIT_NV = 0x00008000
        /// </summary>
        CoverageBufferBitNv = ((int)0x00008000),
    }
    public enum CullFaceMode : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
    }
    public enum DepthFunction : int
    {
        /// <summary>
        /// Original was GL_NEVER = 0x0200
        /// </summary>
        Never = ((int)0x0200),
        /// <summary>
        /// Original was GL_LESS = 0x0201
        /// </summary>
        Less = ((int)0x0201),
        /// <summary>
        /// Original was GL_EQUAL = 0x0202
        /// </summary>
        Equal = ((int)0x0202),
        /// <summary>
        /// Original was GL_LEQUAL = 0x0203
        /// </summary>
        Lequal = ((int)0x0203),
        /// <summary>
        /// Original was GL_GREATER = 0x0204
        /// </summary>
        Greater = ((int)0x0204),
        /// <summary>
        /// Original was GL_NOTEQUAL = 0x0205
        /// </summary>
        Notequal = ((int)0x0205),
        /// <summary>
        /// Original was GL_GEQUAL = 0x0206
        /// </summary>
        Gequal = ((int)0x0206),
        /// <summary>
        /// Original was GL_ALWAYS = 0x0207
        /// </summary>
        Always = ((int)0x0207),
    }
    public enum DrawBufferMode : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_NONE_OES = 0
        /// </summary>
        NoneOes = ((int)0),
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = ((int)0x0406),
        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = ((int)0x0407),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
    }
    public enum DrawBuffersEnum : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
    }
    public enum DrawElementsType : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
    }
    public enum EnableCap : int
    {
        /// <summary>
        /// Original was GL_POINT_SMOOTH = 0x0B10
        /// </summary>
        PointSmooth = ((int)0x0B10),
        /// <summary>
        /// Original was GL_LINE_SMOOTH = 0x0B20
        /// </summary>
        LineSmooth = ((int)0x0B20),
        /// <summary>
        /// Original was GL_LINE_STIPPLE = 0x0B24
        /// </summary>
        LineStipple = ((int)0x0B24),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH = 0x0B41
        /// </summary>
        PolygonSmooth = ((int)0x0B41),
        /// <summary>
        /// Original was GL_POLYGON_STIPPLE = 0x0B42
        /// </summary>
        PolygonStipple = ((int)0x0B42),
        /// <summary>
        /// Original was GL_CULL_FACE = 0x0B44
        /// </summary>
        CullFace = ((int)0x0B44),
        /// <summary>
        /// Original was GL_LIGHTING = 0x0B50
        /// </summary>
        Lighting = ((int)0x0B50),
        /// <summary>
        /// Original was GL_COLOR_MATERIAL = 0x0B57
        /// </summary>
        ColorMaterial = ((int)0x0B57),
        /// <summary>
        /// Original was GL_FOG = 0x0B60
        /// </summary>
        Fog = ((int)0x0B60),
        /// <summary>
        /// Original was GL_DEPTH_TEST = 0x0B71
        /// </summary>
        DepthTest = ((int)0x0B71),
        /// <summary>
        /// Original was GL_STENCIL_TEST = 0x0B90
        /// </summary>
        StencilTest = ((int)0x0B90),
        /// <summary>
        /// Original was GL_NORMALIZE = 0x0BA1
        /// </summary>
        Normalize = ((int)0x0BA1),
        /// <summary>
        /// Original was GL_ALPHA_TEST = 0x0BC0
        /// </summary>
        AlphaTest = ((int)0x0BC0),
        /// <summary>
        /// Original was GL_DITHER = 0x0BD0
        /// </summary>
        Dither = ((int)0x0BD0),
        /// <summary>
        /// Original was GL_BLEND = 0x0BE2
        /// </summary>
        Blend = ((int)0x0BE2),
        /// <summary>
        /// Original was GL_INDEX_LOGIC_OP = 0x0BF1
        /// </summary>
        IndexLogicOp = ((int)0x0BF1),
        /// <summary>
        /// Original was GL_COLOR_LOGIC_OP = 0x0BF2
        /// </summary>
        ColorLogicOp = ((int)0x0BF2),
        /// <summary>
        /// Original was GL_SCISSOR_TEST = 0x0C11
        /// </summary>
        ScissorTest = ((int)0x0C11),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_S = 0x0C60
        /// </summary>
        TextureGenS = ((int)0x0C60),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_T = 0x0C61
        /// </summary>
        TextureGenT = ((int)0x0C61),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_R = 0x0C62
        /// </summary>
        TextureGenR = ((int)0x0C62),
        /// <summary>
        /// Original was GL_TEXTURE_GEN_Q = 0x0C63
        /// </summary>
        TextureGenQ = ((int)0x0C63),
        /// <summary>
        /// Original was GL_AUTO_NORMAL = 0x0D80
        /// </summary>
        AutoNormal = ((int)0x0D80),
        /// <summary>
        /// Original was GL_MAP1_COLOR_4 = 0x0D90
        /// </summary>
        Map1Color4 = ((int)0x0D90),
        /// <summary>
        /// Original was GL_MAP1_INDEX = 0x0D91
        /// </summary>
        Map1Index = ((int)0x0D91),
        /// <summary>
        /// Original was GL_MAP1_NORMAL = 0x0D92
        /// </summary>
        Map1Normal = ((int)0x0D92),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_1 = 0x0D93
        /// </summary>
        Map1TextureCoord1 = ((int)0x0D93),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_2 = 0x0D94
        /// </summary>
        Map1TextureCoord2 = ((int)0x0D94),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_3 = 0x0D95
        /// </summary>
        Map1TextureCoord3 = ((int)0x0D95),
        /// <summary>
        /// Original was GL_MAP1_TEXTURE_COORD_4 = 0x0D96
        /// </summary>
        Map1TextureCoord4 = ((int)0x0D96),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_3 = 0x0D97
        /// </summary>
        Map1Vertex3 = ((int)0x0D97),
        /// <summary>
        /// Original was GL_MAP1_VERTEX_4 = 0x0D98
        /// </summary>
        Map1Vertex4 = ((int)0x0D98),
        /// <summary>
        /// Original was GL_MAP2_COLOR_4 = 0x0DB0
        /// </summary>
        Map2Color4 = ((int)0x0DB0),
        /// <summary>
        /// Original was GL_MAP2_INDEX = 0x0DB1
        /// </summary>
        Map2Index = ((int)0x0DB1),
        /// <summary>
        /// Original was GL_MAP2_NORMAL = 0x0DB2
        /// </summary>
        Map2Normal = ((int)0x0DB2),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_1 = 0x0DB3
        /// </summary>
        Map2TextureCoord1 = ((int)0x0DB3),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_2 = 0x0DB4
        /// </summary>
        Map2TextureCoord2 = ((int)0x0DB4),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_3 = 0x0DB5
        /// </summary>
        Map2TextureCoord3 = ((int)0x0DB5),
        /// <summary>
        /// Original was GL_MAP2_TEXTURE_COORD_4 = 0x0DB6
        /// </summary>
        Map2TextureCoord4 = ((int)0x0DB6),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_3 = 0x0DB7
        /// </summary>
        Map2Vertex3 = ((int)0x0DB7),
        /// <summary>
        /// Original was GL_MAP2_VERTEX_4 = 0x0DB8
        /// </summary>
        Map2Vertex4 = ((int)0x0DB8),
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_POINT = 0x2A01
        /// </summary>
        PolygonOffsetPoint = ((int)0x2A01),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_LINE = 0x2A02
        /// </summary>
        PolygonOffsetLine = ((int)0x2A02),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE0 = 0x3000
        /// </summary>
        ClipDistance0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_PLANE0 = 0x3000
        /// </summary>
        ClipPlane0 = ((int)0x3000),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE1 = 0x3001
        /// </summary>
        ClipDistance1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_PLANE1 = 0x3001
        /// </summary>
        ClipPlane1 = ((int)0x3001),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE2 = 0x3002
        /// </summary>
        ClipDistance2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_PLANE2 = 0x3002
        /// </summary>
        ClipPlane2 = ((int)0x3002),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE3 = 0x3003
        /// </summary>
        ClipDistance3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_PLANE3 = 0x3003
        /// </summary>
        ClipPlane3 = ((int)0x3003),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE4 = 0x3004
        /// </summary>
        ClipDistance4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_PLANE4 = 0x3004
        /// </summary>
        ClipPlane4 = ((int)0x3004),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE5 = 0x3005
        /// </summary>
        ClipDistance5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_PLANE5 = 0x3005
        /// </summary>
        ClipPlane5 = ((int)0x3005),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE6 = 0x3006
        /// </summary>
        ClipDistance6 = ((int)0x3006),
        /// <summary>
        /// Original was GL_CLIP_DISTANCE7 = 0x3007
        /// </summary>
        ClipDistance7 = ((int)0x3007),
        /// <summary>
        /// Original was GL_LIGHT0 = 0x4000
        /// </summary>
        Light0 = ((int)0x4000),
        /// <summary>
        /// Original was GL_LIGHT1 = 0x4001
        /// </summary>
        Light1 = ((int)0x4001),
        /// <summary>
        /// Original was GL_LIGHT2 = 0x4002
        /// </summary>
        Light2 = ((int)0x4002),
        /// <summary>
        /// Original was GL_LIGHT3 = 0x4003
        /// </summary>
        Light3 = ((int)0x4003),
        /// <summary>
        /// Original was GL_LIGHT4 = 0x4004
        /// </summary>
        Light4 = ((int)0x4004),
        /// <summary>
        /// Original was GL_LIGHT5 = 0x4005
        /// </summary>
        Light5 = ((int)0x4005),
        /// <summary>
        /// Original was GL_LIGHT6 = 0x4006
        /// </summary>
        Light6 = ((int)0x4006),
        /// <summary>
        /// Original was GL_LIGHT7 = 0x4007
        /// </summary>
        Light7 = ((int)0x4007),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D = 0x8010
        /// </summary>
        Convolution1D = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_1D_EXT = 0x8010
        /// </summary>
        Convolution1DExt = ((int)0x8010),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D = 0x8011
        /// </summary>
        Convolution2D = ((int)0x8011),
        /// <summary>
        /// Original was GL_CONVOLUTION_2D_EXT = 0x8011
        /// </summary>
        Convolution2DExt = ((int)0x8011),
        /// <summary>
        /// Original was GL_SEPARABLE_2D = 0x8012
        /// </summary>
        Separable2D = ((int)0x8012),
        /// <summary>
        /// Original was GL_SEPARABLE_2D_EXT = 0x8012
        /// </summary>
        Separable2DExt = ((int)0x8012),
        /// <summary>
        /// Original was GL_HISTOGRAM = 0x8024
        /// </summary>
        Histogram = ((int)0x8024),
        /// <summary>
        /// Original was GL_HISTOGRAM_EXT = 0x8024
        /// </summary>
        HistogramExt = ((int)0x8024),
        /// <summary>
        /// Original was GL_MINMAX_EXT = 0x802E
        /// </summary>
        MinmaxExt = ((int)0x802E),
        /// <summary>
        /// Original was GL_POLYGON_OFFSET_FILL = 0x8037
        /// </summary>
        PolygonOffsetFill = ((int)0x8037),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL = 0x803A
        /// </summary>
        RescaleNormal = ((int)0x803A),
        /// <summary>
        /// Original was GL_RESCALE_NORMAL_EXT = 0x803A
        /// </summary>
        RescaleNormalExt = ((int)0x803A),
        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = ((int)0x806F),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY = 0x8074
        /// </summary>
        VertexArray = ((int)0x8074),
        /// <summary>
        /// Original was GL_NORMAL_ARRAY = 0x8075
        /// </summary>
        NormalArray = ((int)0x8075),
        /// <summary>
        /// Original was GL_COLOR_ARRAY = 0x8076
        /// </summary>
        ColorArray = ((int)0x8076),
        /// <summary>
        /// Original was GL_INDEX_ARRAY = 0x8077
        /// </summary>
        IndexArray = ((int)0x8077),
        /// <summary>
        /// Original was GL_TEXTURE_COORD_ARRAY = 0x8078
        /// </summary>
        TextureCoordArray = ((int)0x8078),
        /// <summary>
        /// Original was GL_EDGE_FLAG_ARRAY = 0x8079
        /// </summary>
        EdgeFlagArray = ((int)0x8079),
        /// <summary>
        /// Original was GL_INTERLACE_SGIX = 0x8094
        /// </summary>
        InterlaceSgix = ((int)0x8094),
        /// <summary>
        /// Original was GL_MULTISAMPLE = 0x809D
        /// </summary>
        Multisample = ((int)0x809D),
        /// <summary>
        /// Original was GL_MULTISAMPLE_SGIS = 0x809D
        /// </summary>
        MultisampleSgis = ((int)0x809D),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E
        /// </summary>
        SampleAlphaToCoverage = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_MASK_SGIS = 0x809E
        /// </summary>
        SampleAlphaToMaskSgis = ((int)0x809E),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE = 0x809F
        /// </summary>
        SampleAlphaToOne = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_ALPHA_TO_ONE_SGIS = 0x809F
        /// </summary>
        SampleAlphaToOneSgis = ((int)0x809F),
        /// <summary>
        /// Original was GL_SAMPLE_COVERAGE = 0x80A0
        /// </summary>
        SampleCoverage = ((int)0x80A0),
        /// <summary>
        /// Original was GL_SAMPLE_MASK_SGIS = 0x80A0
        /// </summary>
        SampleMaskSgis = ((int)0x80A0),
        /// <summary>
        /// Original was GL_TEXTURE_COLOR_TABLE_SGI = 0x80BC
        /// </summary>
        TextureColorTableSgi = ((int)0x80BC),
        /// <summary>
        /// Original was GL_COLOR_TABLE = 0x80D0
        /// </summary>
        ColorTable = ((int)0x80D0),
        /// <summary>
        /// Original was GL_COLOR_TABLE_SGI = 0x80D0
        /// </summary>
        ColorTableSgi = ((int)0x80D0),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1
        /// </summary>
        PostConvolutionColorTable = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_CONVOLUTION_COLOR_TABLE_SGI = 0x80D1
        /// </summary>
        PostConvolutionColorTableSgi = ((int)0x80D1),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2
        /// </summary>
        PostColorMatrixColorTable = ((int)0x80D2),
        /// <summary>
        /// Original was GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI = 0x80D2
        /// </summary>
        PostColorMatrixColorTableSgi = ((int)0x80D2),
        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = ((int)0x8134),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_SGIX = 0x8139
        /// </summary>
        PixelTexGenSgix = ((int)0x8139),
        /// <summary>
        /// Original was GL_SPRITE_SGIX = 0x8148
        /// </summary>
        SpriteSgix = ((int)0x8148),
        /// <summary>
        /// Original was GL_REFERENCE_PLANE_SGIX = 0x817D
        /// </summary>
        ReferencePlaneSgix = ((int)0x817D),
        /// <summary>
        /// Original was GL_IR_INSTRUMENT1_SGIX = 0x817F
        /// </summary>
        IrInstrument1Sgix = ((int)0x817F),
        /// <summary>
        /// Original was GL_CALLIGRAPHIC_FRAGMENT_SGIX = 0x8183
        /// </summary>
        CalligraphicFragmentSgix = ((int)0x8183),
        /// <summary>
        /// Original was GL_FRAMEZOOM_SGIX = 0x818B
        /// </summary>
        FramezoomSgix = ((int)0x818B),
        /// <summary>
        /// Original was GL_FOG_OFFSET_SGIX = 0x8198
        /// </summary>
        FogOffsetSgix = ((int)0x8198),
        /// <summary>
        /// Original was GL_SHARED_TEXTURE_PALETTE_EXT = 0x81FB
        /// </summary>
        SharedTexturePaletteExt = ((int)0x81FB),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT_SYNCHRONOUS = 0x8242
        /// </summary>
        DebugOutputSynchronous = ((int)0x8242),
        /// <summary>
        /// Original was GL_ASYNC_HISTOGRAM_SGIX = 0x832C
        /// </summary>
        AsyncHistogramSgix = ((int)0x832C),
        /// <summary>
        /// Original was GL_PIXEL_TEXTURE_SGIS = 0x8353
        /// </summary>
        PixelTextureSgis = ((int)0x8353),
        /// <summary>
        /// Original was GL_ASYNC_TEX_IMAGE_SGIX = 0x835C
        /// </summary>
        AsyncTexImageSgix = ((int)0x835C),
        /// <summary>
        /// Original was GL_ASYNC_DRAW_PIXELS_SGIX = 0x835D
        /// </summary>
        AsyncDrawPixelsSgix = ((int)0x835D),
        /// <summary>
        /// Original was GL_ASYNC_READ_PIXELS_SGIX = 0x835E
        /// </summary>
        AsyncReadPixelsSgix = ((int)0x835E),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHTING_SGIX = 0x8400
        /// </summary>
        FragmentLightingSgix = ((int)0x8400),
        /// <summary>
        /// Original was GL_FRAGMENT_COLOR_MATERIAL_SGIX = 0x8401
        /// </summary>
        FragmentColorMaterialSgix = ((int)0x8401),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT0_SGIX = 0x840C
        /// </summary>
        FragmentLight0Sgix = ((int)0x840C),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT1_SGIX = 0x840D
        /// </summary>
        FragmentLight1Sgix = ((int)0x840D),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT2_SGIX = 0x840E
        /// </summary>
        FragmentLight2Sgix = ((int)0x840E),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT3_SGIX = 0x840F
        /// </summary>
        FragmentLight3Sgix = ((int)0x840F),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT4_SGIX = 0x8410
        /// </summary>
        FragmentLight4Sgix = ((int)0x8410),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT5_SGIX = 0x8411
        /// </summary>
        FragmentLight5Sgix = ((int)0x8411),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT6_SGIX = 0x8412
        /// </summary>
        FragmentLight6Sgix = ((int)0x8412),
        /// <summary>
        /// Original was GL_FRAGMENT_LIGHT7_SGIX = 0x8413
        /// </summary>
        FragmentLight7Sgix = ((int)0x8413),
        /// <summary>
        /// Original was GL_FOG_COORD_ARRAY = 0x8457
        /// </summary>
        FogCoordArray = ((int)0x8457),
        /// <summary>
        /// Original was GL_COLOR_SUM = 0x8458
        /// </summary>
        ColorSum = ((int)0x8458),
        /// <summary>
        /// Original was GL_SECONDARY_COLOR_ARRAY = 0x845E
        /// </summary>
        SecondaryColorArray = ((int)0x845E),
        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = ((int)0x84F5),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513),
        /// <summary>
        /// Original was GL_PROGRAM_POINT_SIZE = 0x8642
        /// </summary>
        ProgramPointSize = ((int)0x8642),
        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_POINT_SIZE = 0x8642
        /// </summary>
        VertexProgramPointSize = ((int)0x8642),
        /// <summary>
        /// Original was GL_VERTEX_PROGRAM_TWO_SIDE = 0x8643
        /// </summary>
        VertexProgramTwoSide = ((int)0x8643),
        /// <summary>
        /// Original was GL_DEPTH_CLAMP = 0x864F
        /// </summary>
        DepthClamp = ((int)0x864F),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_SEAMLESS = 0x884F
        /// </summary>
        TextureCubeMapSeamless = ((int)0x884F),
        /// <summary>
        /// Original was GL_POINT_SPRITE = 0x8861
        /// </summary>
        PointSprite = ((int)0x8861),
        /// <summary>
        /// Original was GL_SAMPLE_SHADING = 0x8C36
        /// </summary>
        SampleShading = ((int)0x8C36),
        /// <summary>
        /// Original was GL_RASTERIZER_DISCARD = 0x8C89
        /// </summary>
        RasterizerDiscard = ((int)0x8C89),
        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART_FIXED_INDEX = 0x8D69
        /// </summary>
        PrimitiveRestartFixedIndex = ((int)0x8D69),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_SRGB = 0x8DB9
        /// </summary>
        FramebufferSrgb = ((int)0x8DB9),
        /// <summary>
        /// Original was GL_SAMPLE_MASK = 0x8E51
        /// </summary>
        SampleMask = ((int)0x8E51),
        /// <summary>
        /// Original was GL_PRIMITIVE_RESTART = 0x8F9D
        /// </summary>
        PrimitiveRestart = ((int)0x8F9D),
        /// <summary>
        /// Original was GL_DEBUG_OUTPUT = 0x92E0
        /// </summary>
        DebugOutput = ((int)0x92E0),
    }
    public enum ErrorCode : int
    {
        /// <summary>
        /// Original was GL_NO_ERROR = 0
        /// </summary>
        NoError = ((int)0),
        /// <summary>
        /// Original was GL_INVALID_ENUM = 0x0500
        /// </summary>
        InvalidEnum = ((int)0x0500),
        /// <summary>
        /// Original was GL_INVALID_VALUE = 0x0501
        /// </summary>
        InvalidValue = ((int)0x0501),
        /// <summary>
        /// Original was GL_INVALID_OPERATION = 0x0502
        /// </summary>
        InvalidOperation = ((int)0x0502),
        /// <summary>
        /// Original was GL_STACK_OVERFLOW = 0x0503
        /// </summary>
        StackOverflow = ((int)0x0503),
        /// <summary>
        /// Original was GL_STACK_UNDERFLOW = 0x0504
        /// </summary>
        StackUnderflow = ((int)0x0504),
        /// <summary>
        /// Original was GL_OUT_OF_MEMORY = 0x0505
        /// </summary>
        OutOfMemory = ((int)0x0505),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION = 0x0506
        /// </summary>
        InvalidFramebufferOperation = ((int)0x0506),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_EXT = 0x0506
        /// </summary>
        InvalidFramebufferOperationExt = ((int)0x0506),
        /// <summary>
        /// Original was GL_INVALID_FRAMEBUFFER_OPERATION_OES = 0x0506
        /// </summary>
        InvalidFramebufferOperationOes = ((int)0x0506),
        /// <summary>
        /// Original was GL_CONTEXT_LOST = 0x0507
        /// </summary>
        ContextLost = ((int)0x0507),
        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE = 0x8031
        /// </summary>
        TableTooLarge = ((int)0x8031),
        /// <summary>
        /// Original was GL_TABLE_TOO_LARGE_EXT = 0x8031
        /// </summary>
        TableTooLargeExt = ((int)0x8031),
        /// <summary>
        /// Original was GL_TEXTURE_TOO_LARGE_EXT = 0x8065
        /// </summary>
        TextureTooLargeExt = ((int)0x8065),
    }
    public enum ExtTextureFilterAnisotropic : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE
        /// </summary>
        TextureMaxAnisotropyExt = ((int)0x84FE),
        /// <summary>
        /// Original was GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF
        /// </summary>
        MaxTextureMaxAnisotropyExt = ((int)0x84FF),
    }
    public enum FramebufferAttachment : int
    {
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800),
        /// <summary>
        /// Original was GL_DEPTH = 0x1801
        /// </summary>
        Depth = ((int)0x1801),
        /// <summary>
        /// Original was GL_STENCIL = 0x1802
        /// </summary>
        Stencil = ((int)0x1802),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_ATTACHMENT = 0x821A
        /// </summary>
        DepthStencilAttachment = ((int)0x821A),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS = 0x8CDF
        /// </summary>
        MaxColorAttachments = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_EXT = 0x8CDF
        /// </summary>
        MaxColorAttachmentsExt = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_MAX_COLOR_ATTACHMENTS_NV = 0x8CDF
        /// </summary>
        MaxColorAttachmentsNv = ((int)0x8CDF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_EXT = 0x8CE0
        /// </summary>
        ColorAttachment0Ext = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_NV = 0x8CE0
        /// </summary>
        ColorAttachment0Nv = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0_OES = 0x8CE0
        /// </summary>
        ColorAttachment0Oes = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_EXT = 0x8CE1
        /// </summary>
        ColorAttachment1Ext = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1_NV = 0x8CE1
        /// </summary>
        ColorAttachment1Nv = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_EXT = 0x8CE2
        /// </summary>
        ColorAttachment2Ext = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2_NV = 0x8CE2
        /// </summary>
        ColorAttachment2Nv = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_EXT = 0x8CE3
        /// </summary>
        ColorAttachment3Ext = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3_NV = 0x8CE3
        /// </summary>
        ColorAttachment3Nv = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_EXT = 0x8CE4
        /// </summary>
        ColorAttachment4Ext = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4_NV = 0x8CE4
        /// </summary>
        ColorAttachment4Nv = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_EXT = 0x8CE5
        /// </summary>
        ColorAttachment5Ext = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5_NV = 0x8CE5
        /// </summary>
        ColorAttachment5Nv = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_EXT = 0x8CE6
        /// </summary>
        ColorAttachment6Ext = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6_NV = 0x8CE6
        /// </summary>
        ColorAttachment6Nv = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_EXT = 0x8CE7
        /// </summary>
        ColorAttachment7Ext = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7_NV = 0x8CE7
        /// </summary>
        ColorAttachment7Nv = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_EXT = 0x8CE8
        /// </summary>
        ColorAttachment8Ext = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8_NV = 0x8CE8
        /// </summary>
        ColorAttachment8Nv = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_EXT = 0x8CE9
        /// </summary>
        ColorAttachment9Ext = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9_NV = 0x8CE9
        /// </summary>
        ColorAttachment9Nv = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_EXT = 0x8CEA
        /// </summary>
        ColorAttachment10Ext = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10_NV = 0x8CEA
        /// </summary>
        ColorAttachment10Nv = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_EXT = 0x8CEB
        /// </summary>
        ColorAttachment11Ext = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11_NV = 0x8CEB
        /// </summary>
        ColorAttachment11Nv = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_EXT = 0x8CEC
        /// </summary>
        ColorAttachment12Ext = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12_NV = 0x8CEC
        /// </summary>
        ColorAttachment12Nv = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_EXT = 0x8CED
        /// </summary>
        ColorAttachment13Ext = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13_NV = 0x8CED
        /// </summary>
        ColorAttachment13Nv = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_EXT = 0x8CEE
        /// </summary>
        ColorAttachment14Ext = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14_NV = 0x8CEE
        /// </summary>
        ColorAttachment14Nv = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_EXT = 0x8CEF
        /// </summary>
        ColorAttachment15Ext = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15_NV = 0x8CEF
        /// </summary>
        ColorAttachment15Nv = ((int)0x8CEF),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT16 = 0x8CF0
        /// </summary>
        ColorAttachment16 = ((int)0x8CF0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT17 = 0x8CF1
        /// </summary>
        ColorAttachment17 = ((int)0x8CF1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT18 = 0x8CF2
        /// </summary>
        ColorAttachment18 = ((int)0x8CF2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT19 = 0x8CF3
        /// </summary>
        ColorAttachment19 = ((int)0x8CF3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT20 = 0x8CF4
        /// </summary>
        ColorAttachment20 = ((int)0x8CF4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT21 = 0x8CF5
        /// </summary>
        ColorAttachment21 = ((int)0x8CF5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT22 = 0x8CF6
        /// </summary>
        ColorAttachment22 = ((int)0x8CF6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT23 = 0x8CF7
        /// </summary>
        ColorAttachment23 = ((int)0x8CF7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT24 = 0x8CF8
        /// </summary>
        ColorAttachment24 = ((int)0x8CF8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT25 = 0x8CF9
        /// </summary>
        ColorAttachment25 = ((int)0x8CF9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT26 = 0x8CFA
        /// </summary>
        ColorAttachment26 = ((int)0x8CFA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT27 = 0x8CFB
        /// </summary>
        ColorAttachment27 = ((int)0x8CFB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT28 = 0x8CFC
        /// </summary>
        ColorAttachment28 = ((int)0x8CFC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT29 = 0x8CFD
        /// </summary>
        ColorAttachment29 = ((int)0x8CFD),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT30 = 0x8CFE
        /// </summary>
        ColorAttachment30 = ((int)0x8CFE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT31 = 0x8CFF
        /// </summary>
        ColorAttachment31 = ((int)0x8CFF),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT = 0x8D00
        /// </summary>
        DepthAttachment = ((int)0x8D00),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_EXT = 0x8D00
        /// </summary>
        DepthAttachmentExt = ((int)0x8D00),
        /// <summary>
        /// Original was GL_DEPTH_ATTACHMENT_OES = 0x8D00
        /// </summary>
        DepthAttachmentOes = ((int)0x8D00),
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT = 0x8D20
        /// </summary>
        StencilAttachment = ((int)0x8D20),
        /// <summary>
        /// Original was GL_STENCIL_ATTACHMENT_EXT = 0x8D20
        /// </summary>
        StencilAttachmentExt = ((int)0x8D20),
    }
    public enum FramebufferErrorCode : int
    {
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNDEFINED = 0x8219
        /// </summary>
        FramebufferUndefined = ((int)0x8219),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE = 0x8CD5
        /// </summary>
        FramebufferComplete = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_COMPLETE_EXT = 0x8CD5
        /// </summary>
        FramebufferCompleteExt = ((int)0x8CD5),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachment = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT_EXT = 0x8CD6
        /// </summary>
        FramebufferIncompleteAttachmentExt = ((int)0x8CD6),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachment = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT_EXT = 0x8CD7
        /// </summary>
        FramebufferIncompleteMissingAttachmentExt = ((int)0x8CD7),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DIMENSIONS_EXT = 0x8CD9
        /// </summary>
        FramebufferIncompleteDimensionsExt = ((int)0x8CD9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_FORMATS_EXT = 0x8CDA
        /// </summary>
        FramebufferIncompleteFormatsExt = ((int)0x8CDA),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBuffer = ((int)0x8CDB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER_EXT = 0x8CDB
        /// </summary>
        FramebufferIncompleteDrawBufferExt = ((int)0x8CDB),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBuffer = ((int)0x8CDC),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER_EXT = 0x8CDC
        /// </summary>
        FramebufferIncompleteReadBufferExt = ((int)0x8CDC),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED = 0x8CDD
        /// </summary>
        FramebufferUnsupported = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_UNSUPPORTED_EXT = 0x8CDD
        /// </summary>
        FramebufferUnsupportedExt = ((int)0x8CDD),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE = 0x8D56
        /// </summary>
        FramebufferIncompleteMultisample = ((int)0x8D56),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS = 0x8DA8
        /// </summary>
        FramebufferIncompleteLayerTargets = ((int)0x8DA8),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_INCOMPLETE_LAYER_COUNT = 0x8DA9
        /// </summary>
        FramebufferIncompleteLayerCount = ((int)0x8DA9),
    }
    public enum FramebufferTarget : int
    {
        /// <summary>
        /// Original was GL_READ_FRAMEBUFFER = 0x8CA8
        /// </summary>
        ReadFramebuffer = ((int)0x8CA8),
        /// <summary>
        /// Original was GL_DRAW_FRAMEBUFFER = 0x8CA9
        /// </summary>
        DrawFramebuffer = ((int)0x8CA9),
        /// <summary>
        /// Original was GL_FRAMEBUFFER = 0x8D40
        /// </summary>
        Framebuffer = ((int)0x8D40),
        /// <summary>
        /// Original was GL_FRAMEBUFFER_EXT = 0x8D40
        /// </summary>
        FramebufferExt = ((int)0x8D40),
    }
    public enum GenerateMipmapTarget : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = ((int)0x8C18),
        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = ((int)0x8C1A),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = ((int)0x9100),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = ((int)0x9102),
    }
    public enum GetProgramParameterName : int
    {
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257),
        /// <summary>
        /// Original was GL_PROGRAM_SEPARABLE = 0x8258
        /// </summary>
        ProgramSeparable = ((int)0x8258),
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_INVOCATIONS = 0x887F
        /// </summary>
        GeometryShaderInvocations = ((int)0x887F),
        /// <summary>
        /// Original was GL_GEOMETRY_VERTICES_OUT = 0x8916
        /// </summary>
        GeometryVerticesOut = ((int)0x8916),
        /// <summary>
        /// Original was GL_GEOMETRY_INPUT_TYPE = 0x8917
        /// </summary>
        GeometryInputType = ((int)0x8917),
        /// <summary>
        /// Original was GL_GEOMETRY_OUTPUT_TYPE = 0x8918
        /// </summary>
        GeometryOutputType = ((int)0x8918),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH = 0x8A35
        /// </summary>
        ActiveUniformBlockMaxNameLength = ((int)0x8A35),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_BLOCKS = 0x8A36
        /// </summary>
        ActiveUniformBlocks = ((int)0x8A36),
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80),
        /// <summary>
        /// Original was GL_LINK_STATUS = 0x8B82
        /// </summary>
        LinkStatus = ((int)0x8B82),
        /// <summary>
        /// Original was GL_VALIDATE_STATUS = 0x8B83
        /// </summary>
        ValidateStatus = ((int)0x8B83),
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84),
        /// <summary>
        /// Original was GL_ATTACHED_SHADERS = 0x8B85
        /// </summary>
        AttachedShaders = ((int)0x8B85),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORMS = 0x8B86
        /// </summary>
        ActiveUniforms = ((int)0x8B86),
        /// <summary>
        /// Original was GL_ACTIVE_UNIFORM_MAX_LENGTH = 0x8B87
        /// </summary>
        ActiveUniformMaxLength = ((int)0x8B87),
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTES = 0x8B89
        /// </summary>
        ActiveAttributes = ((int)0x8B89),
        /// <summary>
        /// Original was GL_ACTIVE_ATTRIBUTE_MAX_LENGTH = 0x8B8A
        /// </summary>
        ActiveAttributeMaxLength = ((int)0x8B8A),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH = 0x8C76
        /// </summary>
        TransformFeedbackVaryingMaxLength = ((int)0x8C76),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_BUFFER_MODE = 0x8C7F
        /// </summary>
        TransformFeedbackBufferMode = ((int)0x8C7F),
        /// <summary>
        /// Original was GL_TRANSFORM_FEEDBACK_VARYINGS = 0x8C83
        /// </summary>
        TransformFeedbackVaryings = ((int)0x8C83),
        /// <summary>
        /// Original was GL_TESS_CONTROL_OUTPUT_VERTICES = 0x8E75
        /// </summary>
        TessControlOutputVertices = ((int)0x8E75),
        /// <summary>
        /// Original was GL_TESS_GEN_MODE = 0x8E76
        /// </summary>
        TessGenMode = ((int)0x8E76),
        /// <summary>
        /// Original was GL_TESS_GEN_SPACING = 0x8E77
        /// </summary>
        TessGenSpacing = ((int)0x8E77),
        /// <summary>
        /// Original was GL_TESS_GEN_VERTEX_ORDER = 0x8E78
        /// </summary>
        TessGenVertexOrder = ((int)0x8E78),
        /// <summary>
        /// Original was GL_TESS_GEN_POINT_MODE = 0x8E79
        /// </summary>
        TessGenPointMode = ((int)0x8E79),
        /// <summary>
        /// Original was GL_MAX_COMPUTE_WORK_GROUP_SIZE = 0x91BF
        /// </summary>
        MaxComputeWorkGroupSize = ((int)0x91BF),
        /// <summary>
        /// Original was GL_ACTIVE_ATOMIC_COUNTER_BUFFERS = 0x92D9
        /// </summary>
        ActiveAtomicCounterBuffers = ((int)0x92D9),
    }
    public enum HintMode : int
    {
        /// <summary>
        /// Original was GL_DONT_CARE = 0x1100
        /// </summary>
        DontCare = ((int)0x1100),
        /// <summary>
        /// Original was GL_FASTEST = 0x1101
        /// </summary>
        Fastest = ((int)0x1101),
        /// <summary>
        /// Original was GL_NICEST = 0x1102
        /// </summary>
        Nicest = ((int)0x1102),
    }
    public enum HintTarget : int
    {
        /// <summary>
        /// Original was GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50
        /// </summary>
        PerspectiveCorrectionHint = ((int)0x0C50),
        /// <summary>
        /// Original was GL_POINT_SMOOTH_HINT = 0x0C51
        /// </summary>
        PointSmoothHint = ((int)0x0C51),
        /// <summary>
        /// Original was GL_LINE_SMOOTH_HINT = 0x0C52
        /// </summary>
        LineSmoothHint = ((int)0x0C52),
        /// <summary>
        /// Original was GL_POLYGON_SMOOTH_HINT = 0x0C53
        /// </summary>
        PolygonSmoothHint = ((int)0x0C53),
        /// <summary>
        /// Original was GL_FOG_HINT = 0x0C54
        /// </summary>
        FogHint = ((int)0x0C54),
        /// <summary>
        /// Original was GL_PREFER_DOUBLEBUFFER_HINT_PGI = 0x1A1F8
        /// </summary>
        PreferDoublebufferHintPgi = ((int)0x1A1F8),
        /// <summary>
        /// Original was GL_CONSERVE_MEMORY_HINT_PGI = 0x1A1FD
        /// </summary>
        ConserveMemoryHintPgi = ((int)0x1A1FD),
        /// <summary>
        /// Original was GL_RECLAIM_MEMORY_HINT_PGI = 0x1A1FE
        /// </summary>
        ReclaimMemoryHintPgi = ((int)0x1A1FE),
        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI = 0x1A203
        /// </summary>
        NativeGraphicsBeginHintPgi = ((int)0x1A203),
        /// <summary>
        /// Original was GL_NATIVE_GRAPHICS_END_HINT_PGI = 0x1A204
        /// </summary>
        NativeGraphicsEndHintPgi = ((int)0x1A204),
        /// <summary>
        /// Original was GL_ALWAYS_FAST_HINT_PGI = 0x1A20C
        /// </summary>
        AlwaysFastHintPgi = ((int)0x1A20C),
        /// <summary>
        /// Original was GL_ALWAYS_SOFT_HINT_PGI = 0x1A20D
        /// </summary>
        AlwaysSoftHintPgi = ((int)0x1A20D),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_OBJ_HINT_PGI = 0x1A20E
        /// </summary>
        AllowDrawObjHintPgi = ((int)0x1A20E),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_WIN_HINT_PGI = 0x1A20F
        /// </summary>
        AllowDrawWinHintPgi = ((int)0x1A20F),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_FRG_HINT_PGI = 0x1A210
        /// </summary>
        AllowDrawFrgHintPgi = ((int)0x1A210),
        /// <summary>
        /// Original was GL_ALLOW_DRAW_MEM_HINT_PGI = 0x1A211
        /// </summary>
        AllowDrawMemHintPgi = ((int)0x1A211),
        /// <summary>
        /// Original was GL_STRICT_DEPTHFUNC_HINT_PGI = 0x1A216
        /// </summary>
        StrictDepthfuncHintPgi = ((int)0x1A216),
        /// <summary>
        /// Original was GL_STRICT_LIGHTING_HINT_PGI = 0x1A217
        /// </summary>
        StrictLightingHintPgi = ((int)0x1A217),
        /// <summary>
        /// Original was GL_STRICT_SCISSOR_HINT_PGI = 0x1A218
        /// </summary>
        StrictScissorHintPgi = ((int)0x1A218),
        /// <summary>
        /// Original was GL_FULL_STIPPLE_HINT_PGI = 0x1A219
        /// </summary>
        FullStippleHintPgi = ((int)0x1A219),
        /// <summary>
        /// Original was GL_CLIP_NEAR_HINT_PGI = 0x1A220
        /// </summary>
        ClipNearHintPgi = ((int)0x1A220),
        /// <summary>
        /// Original was GL_CLIP_FAR_HINT_PGI = 0x1A221
        /// </summary>
        ClipFarHintPgi = ((int)0x1A221),
        /// <summary>
        /// Original was GL_WIDE_LINE_HINT_PGI = 0x1A222
        /// </summary>
        WideLineHintPgi = ((int)0x1A222),
        /// <summary>
        /// Original was GL_BACK_NORMALS_HINT_PGI = 0x1A223
        /// </summary>
        BackNormalsHintPgi = ((int)0x1A223),
        /// <summary>
        /// Original was GL_VERTEX_DATA_HINT_PGI = 0x1A22A
        /// </summary>
        VertexDataHintPgi = ((int)0x1A22A),
        /// <summary>
        /// Original was GL_VERTEX_CONSISTENT_HINT_PGI = 0x1A22B
        /// </summary>
        VertexConsistentHintPgi = ((int)0x1A22B),
        /// <summary>
        /// Original was GL_MATERIAL_SIDE_HINT_PGI = 0x1A22C
        /// </summary>
        MaterialSideHintPgi = ((int)0x1A22C),
        /// <summary>
        /// Original was GL_MAX_VERTEX_HINT_PGI = 0x1A22D
        /// </summary>
        MaxVertexHintPgi = ((int)0x1A22D),
        /// <summary>
        /// Original was GL_PACK_CMYK_HINT_EXT = 0x800E
        /// </summary>
        PackCmykHintExt = ((int)0x800E),
        /// <summary>
        /// Original was GL_UNPACK_CMYK_HINT_EXT = 0x800F
        /// </summary>
        UnpackCmykHintExt = ((int)0x800F),
        /// <summary>
        /// Original was GL_PHONG_HINT_WIN = 0x80EB
        /// </summary>
        PhongHintWin = ((int)0x80EB),
        /// <summary>
        /// Original was GL_CLIP_VOLUME_CLIPPING_HINT_EXT = 0x80F0
        /// </summary>
        ClipVolumeClippingHintExt = ((int)0x80F0),
        /// <summary>
        /// Original was GL_TEXTURE_MULTI_BUFFER_HINT_SGIX = 0x812E
        /// </summary>
        TextureMultiBufferHintSgix = ((int)0x812E),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT = 0x8192
        /// </summary>
        GenerateMipmapHint = ((int)0x8192),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192
        /// </summary>
        GenerateMipmapHintSgis = ((int)0x8192),
        /// <summary>
        /// Original was GL_PROGRAM_BINARY_RETRIEVABLE_HINT = 0x8257
        /// </summary>
        ProgramBinaryRetrievableHint = ((int)0x8257),
        /// <summary>
        /// Original was GL_CONVOLUTION_HINT_SGIX = 0x8316
        /// </summary>
        ConvolutionHintSgix = ((int)0x8316),
        /// <summary>
        /// Original was GL_SCALEBIAS_HINT_SGIX = 0x8322
        /// </summary>
        ScalebiasHintSgix = ((int)0x8322),
        /// <summary>
        /// Original was GL_LINE_QUALITY_HINT_SGIX = 0x835B
        /// </summary>
        LineQualityHintSgix = ((int)0x835B),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_SGIX = 0x83EE
        /// </summary>
        VertexPreclipSgix = ((int)0x83EE),
        /// <summary>
        /// Original was GL_VERTEX_PRECLIP_HINT_SGIX = 0x83EF
        /// </summary>
        VertexPreclipHintSgix = ((int)0x83EF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT = 0x84EF
        /// </summary>
        TextureCompressionHint = ((int)0x84EF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF
        /// </summary>
        TextureCompressionHintArb = ((int)0x84EF),
        /// <summary>
        /// Original was GL_VERTEX_ARRAY_STORAGE_HINT_APPLE = 0x851F
        /// </summary>
        VertexArrayStorageHintApple = ((int)0x851F),
        /// <summary>
        /// Original was GL_MULTISAMPLE_FILTER_HINT_NV = 0x8534
        /// </summary>
        MultisampleFilterHintNv = ((int)0x8534),
        /// <summary>
        /// Original was GL_TRANSFORM_HINT_APPLE = 0x85B1
        /// </summary>
        TransformHintApple = ((int)0x85B1),
        /// <summary>
        /// Original was GL_TEXTURE_STORAGE_HINT_APPLE = 0x85BC
        /// </summary>
        TextureStorageHintApple = ((int)0x85BC),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHint = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintArb = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES = 0x8B8B
        /// </summary>
        FragmentShaderDerivativeHintOes = ((int)0x8B8B),
        /// <summary>
        /// Original was GL_BINNING_CONTROL_HINT_QCOM = 0x8FB0
        /// </summary>
        BinningControlHintQcom = ((int)0x8FB0),
    }
    public enum InternalFormat : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = ((int)0x1903),
        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = ((int)0x1903),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = ((int)0x2A10),
        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = ((int)0x803B),
        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = ((int)0x803D),
        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = ((int)0x803E),
        /// <summary>
        /// Original was GL_LUMINANCE4 = 0x803F
        /// </summary>
        Luminance4 = ((int)0x803F),
        /// <summary>
        /// Original was GL_LUMINANCE8 = 0x8040
        /// </summary>
        Luminance8 = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE12 = 0x8041
        /// </summary>
        Luminance12 = ((int)0x8041),
        /// <summary>
        /// Original was GL_LUMINANCE16 = 0x8042
        /// </summary>
        Luminance16 = ((int)0x8042),
        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        /// </summary>
        Luminance4Alpha4 = ((int)0x8043),
        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        /// </summary>
        Luminance6Alpha2 = ((int)0x8044),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        /// </summary>
        Luminance8Alpha8 = ((int)0x8045),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        /// </summary>
        Luminance12Alpha4 = ((int)0x8046),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        /// </summary>
        Luminance12Alpha12 = ((int)0x8047),
        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        /// </summary>
        Luminance16Alpha16 = ((int)0x8048),
        /// <summary>
        /// Original was GL_INTENSITY = 0x8049
        /// </summary>
        Intensity = ((int)0x8049),
        /// <summary>
        /// Original was GL_INTENSITY4 = 0x804A
        /// </summary>
        Intensity4 = ((int)0x804A),
        /// <summary>
        /// Original was GL_INTENSITY8 = 0x804B
        /// </summary>
        Intensity8 = ((int)0x804B),
        /// <summary>
        /// Original was GL_INTENSITY12 = 0x804C
        /// </summary>
        Intensity12 = ((int)0x804C),
        /// <summary>
        /// Original was GL_INTENSITY16 = 0x804D
        /// </summary>
        Intensity16 = ((int)0x804D),
        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = ((int)0x804E),
        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB4_EXT = 0x804F
        /// </summary>
        Rgb4Ext = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB5_EXT = 0x8050
        /// </summary>
        Rgb5Ext = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB8_EXT = 0x8051
        /// </summary>
        Rgb8Ext = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB8_OES = 0x8051
        /// </summary>
        Rgb8Oes = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB10_EXT = 0x8052
        /// </summary>
        Rgb10Ext = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB12_EXT = 0x8053
        /// </summary>
        Rgb12Ext = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGB16_EXT = 0x8054
        /// </summary>
        Rgb16Ext = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA4_EXT = 0x8056
        /// </summary>
        Rgba4Ext = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA4_OES = 0x8056
        /// </summary>
        Rgba4Oes = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGB5_A1_EXT = 0x8057
        /// </summary>
        Rgb5A1Ext = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGB5_A1_OES = 0x8057
        /// </summary>
        Rgb5A1Oes = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGBA8_EXT = 0x8058
        /// </summary>
        Rgba8Ext = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGBA8_OES = 0x8058
        /// </summary>
        Rgba8Oes = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGB10_A2_EXT = 0x8059
        /// </summary>
        Rgb10A2Ext = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA12_EXT = 0x805A
        /// </summary>
        Rgba12Ext = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = ((int)0x805B),
        /// <summary>
        /// Original was GL_RGBA16_EXT = 0x805B
        /// </summary>
        Rgba16Ext = ((int)0x805B),
        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = ((int)0x8110),
        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = ((int)0x8111),
        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = ((int)0x8112),
        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = ((int)0x8113),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = ((int)0x8114),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = ((int)0x8115),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = ((int)0x8116),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = ((int)0x8117),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = ((int)0x8118),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = ((int)0x8119),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = ((int)0x811A),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = ((int)0x811B),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = ((int)0x811C),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = ((int)0x811D),
        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = ((int)0x811E),
        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = ((int)0x811F),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = ((int)0x8120),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = ((int)0x8121),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = ((int)0x8122),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = ((int)0x8123),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81A5
        /// </summary>
        DepthComponent16 = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_ARB = 0x81A5
        /// </summary>
        DepthComponent16Arb = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_OES = 0x81A5
        /// </summary>
        DepthComponent16Oes = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_ARB = 0x81A6
        /// </summary>
        DepthComponent24Arb = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_OES = 0x81A6
        /// </summary>
        DepthComponent24Oes = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_ARB = 0x81A7
        /// </summary>
        DepthComponent32Arb = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_OES = 0x81A7
        /// </summary>
        DepthComponent32Oes = ((int)0x81A7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = ((int)0x81A7),
        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = ((int)0x8225),
        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = ((int)0x8226),
        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = ((int)0x8227),
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229),
        /// <summary>
        /// Original was GL_R8_EXT = 0x8229
        /// </summary>
        R8Ext = ((int)0x8229),
        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = ((int)0x822A),
        /// <summary>
        /// Original was GL_R16_EXT = 0x822A
        /// </summary>
        R16Ext = ((int)0x822A),
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG8_EXT = 0x822B
        /// </summary>
        Rg8Ext = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = ((int)0x822C),
        /// <summary>
        /// Original was GL_RG16_EXT = 0x822C
        /// </summary>
        Rg16Ext = ((int)0x822C),
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D),
        /// <summary>
        /// Original was GL_R16F_EXT = 0x822D
        /// </summary>
        R16fExt = ((int)0x822D),
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E),
        /// <summary>
        /// Original was GL_R32F_EXT = 0x822E
        /// </summary>
        R32fExt = ((int)0x822E),
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG16F_EXT = 0x822F
        /// </summary>
        Rg16fExt = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230),
        /// <summary>
        /// Original was GL_RG32F_EXT = 0x8230
        /// </summary>
        Rg32fExt = ((int)0x8230),
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231),
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232),
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233),
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234),
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235),
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236),
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237),
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238),
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239),
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A),
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B),
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = ((int)0x84ED),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = ((int)0x84EE),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_EXT = 0x84F9
        /// </summary>
        DepthStencilExt = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_NV = 0x84F9
        /// </summary>
        DepthStencilNv = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_OES = 0x84F9
        /// </summary>
        DepthStencilOes = ((int)0x84F9),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_MESA = 0x8750
        /// </summary>
        DepthStencilMesa = ((int)0x8750),
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA32F_ARB = 0x8814
        /// </summary>
        Rgba32fArb = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA32F_EXT = 0x8814
        /// </summary>
        Rgba32fExt = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGBA16F_ARB = 0x881A
        /// </summary>
        Rgba16fArb = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGBA16F_EXT = 0x881A
        /// </summary>
        Rgba16fExt = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B),
        /// <summary>
        /// Original was GL_RGB16F_ARB = 0x881B
        /// </summary>
        Rgb16fArb = ((int)0x881B),
        /// <summary>
        /// Original was GL_RGB16F_EXT = 0x881B
        /// </summary>
        Rgb16fExt = ((int)0x881B),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_EXT = 0x88F0
        /// </summary>
        Depth24Stencil8Ext = ((int)0x88F0),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8_OES = 0x88F0
        /// </summary>
        Depth24Stencil8Oes = ((int)0x88F0),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F_APPLE = 0x8C3A
        /// </summary>
        R11fG11fB10fApple = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F_EXT = 0x8C3A
        /// </summary>
        R11fG11fB10fExt = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_RGB9_E5_APPLE = 0x8C3D
        /// </summary>
        Rgb9E5Apple = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_RGB9_E5_EXT = 0x8C3D
        /// </summary>
        Rgb9E5Ext = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB_EXT = 0x8C40
        /// </summary>
        SrgbExt = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_EXT = 0x8C41
        /// </summary>
        Srgb8Ext = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_NV = 0x8C41
        /// </summary>
        Srgb8Nv = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB_ALPHA_EXT = 0x8C42
        /// </summary>
        SrgbAlphaExt = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8_EXT = 0x8C43
        /// </summary>
        Srgb8Alpha8Ext = ((int)0x8C43),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = ((int)0x8C48),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = ((int)0x8C49),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD),
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70),
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71),
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76),
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77),
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C),
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D),
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82),
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83),
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88),
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89),
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E),
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F_NV = 0x8DAB
        /// </summary>
        DepthComponent32fNv = ((int)0x8DAB),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8_NV = 0x8DAC
        /// </summary>
        Depth32fStencil8Nv = ((int)0x8DAC),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1_EXT = 0x8DBB
        /// </summary>
        CompressedRedRgtc1Ext = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1_EXT = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1Ext = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = ((int)0x8DBD),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = ((int)0x8DBE),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = ((int)0x8E8D),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F),
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94),
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95),
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96),
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97),
        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = ((int)0x8F98),
        /// <summary>
        /// Original was GL_R16_SNORM_EXT = 0x8F98
        /// </summary>
        R16SnormExt = ((int)0x8F98),
        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RG16_SNORM_EXT = 0x8F99
        /// </summary>
        Rg16SnormExt = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_RGB16_SNORM_EXT = 0x8F9A
        /// </summary>
        Rgb16SnormExt = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F),
        /// <summary>
        /// Original was GL_COMPRESSED_R11_EAC = 0x9270
        /// </summary>
        CompressedR11Eac = ((int)0x9270),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_R11_EAC = 0x9271
        /// </summary>
        CompressedSignedR11Eac = ((int)0x9271),
        /// <summary>
        /// Original was GL_COMPRESSED_RG11_EAC = 0x9272
        /// </summary>
        CompressedRg11Eac = ((int)0x9272),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG11_EAC = 0x9273
        /// </summary>
        CompressedSignedRg11Eac = ((int)0x9273),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_ETC2 = 0x9274
        /// </summary>
        CompressedRgb8Etc2 = ((int)0x9274),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ETC2 = 0x9275
        /// </summary>
        CompressedSrgb8Etc2 = ((int)0x9275),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9276
        /// </summary>
        CompressedRgb8PunchthroughAlpha1Etc2 = ((int)0x9276),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2 = 0x9277
        /// </summary>
        CompressedSrgb8PunchthroughAlpha1Etc2 = ((int)0x9277),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA8_ETC2_EAC = 0x9278
        /// </summary>
        CompressedRgba8Etc2Eac = ((int)0x9278),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC = 0x9279
        /// </summary>
        CompressedSrgb8Alpha8Etc2Eac = ((int)0x9279),
    }
    public enum MaterialFace : int
    {
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
    }
    public enum MatrixMode : int
    {
        /// <summary>
        /// Original was GL_MODELVIEW = 0x1700
        /// </summary>
        Modelview = ((int)0x1700),
        /// <summary>
        /// Original was GL_MODELVIEW0_EXT = 0x1700
        /// </summary>
        Modelview0Ext = ((int)0x1700),
        /// <summary>
        /// Original was GL_PROJECTION = 0x1701
        /// </summary>
        Projection = ((int)0x1701),
        /// <summary>
        /// Original was GL_TEXTURE = 0x1702
        /// </summary>
        Texture = ((int)0x1702),
        /// <summary>
        /// Original was GL_COLOR = 0x1800
        /// </summary>
        Color = ((int)0x1800),
    }
    public enum PixelFormat : int
    {
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_COLOR_INDEX = 0x1900
        /// </summary>
        ColorIndex = ((int)0x1900),
        /// <summary>
        /// Original was GL_STENCIL_INDEX = 0x1901
        /// </summary>
        StencilIndex = ((int)0x1901),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_RED = 0x1903
        /// </summary>
        Red = ((int)0x1903),
        /// <summary>
        /// Original was GL_RED_EXT = 0x1903
        /// </summary>
        RedExt = ((int)0x1903),
        /// <summary>
        /// Original was GL_GREEN = 0x1904
        /// </summary>
        Green = ((int)0x1904),
        /// <summary>
        /// Original was GL_BLUE = 0x1905
        /// </summary>
        Blue = ((int)0x1905),
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A),
        /// <summary>
        /// Original was GL_ABGR_EXT = 0x8000
        /// </summary>
        AbgrExt = ((int)0x8000),
        /// <summary>
        /// Original was GL_CMYK_EXT = 0x800C
        /// </summary>
        CmykExt = ((int)0x800C),
        /// <summary>
        /// Original was GL_CMYKA_EXT = 0x800D
        /// </summary>
        CmykaExt = ((int)0x800D),
        /// <summary>
        /// Original was GL_BGR = 0x80E0
        /// </summary>
        Bgr = ((int)0x80E0),
        /// <summary>
        /// Original was GL_BGRA = 0x80E1
        /// </summary>
        Bgra = ((int)0x80E1),
        /// <summary>
        /// Original was GL_YCRCB_422_SGIX = 0x81BB
        /// </summary>
        Ycrcb422Sgix = ((int)0x81BB),
        /// <summary>
        /// Original was GL_YCRCB_444_SGIX = 0x81BC
        /// </summary>
        Ycrcb444Sgix = ((int)0x81BC),
        /// <summary>
        /// Original was GL_RG = 0x8227
        /// </summary>
        Rg = ((int)0x8227),
        /// <summary>
        /// Original was GL_RG_INTEGER = 0x8228
        /// </summary>
        RgInteger = ((int)0x8228),
        /// <summary>
        /// Original was GL_R5_G6_B5_ICC_SGIX = 0x8466
        /// </summary>
        R5G6B5IccSgix = ((int)0x8466),
        /// <summary>
        /// Original was GL_R5_G6_B5_A8_ICC_SGIX = 0x8467
        /// </summary>
        R5G6B5A8IccSgix = ((int)0x8467),
        /// <summary>
        /// Original was GL_ALPHA16_ICC_SGIX = 0x8468
        /// </summary>
        Alpha16IccSgix = ((int)0x8468),
        /// <summary>
        /// Original was GL_LUMINANCE16_ICC_SGIX = 0x8469
        /// </summary>
        Luminance16IccSgix = ((int)0x8469),
        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        /// </summary>
        Luminance16Alpha8IccSgix = ((int)0x846B),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9),
        /// <summary>
        /// Original was GL_RED_INTEGER = 0x8D94
        /// </summary>
        RedInteger = ((int)0x8D94),
        /// <summary>
        /// Original was GL_GREEN_INTEGER = 0x8D95
        /// </summary>
        GreenInteger = ((int)0x8D95),
        /// <summary>
        /// Original was GL_BLUE_INTEGER = 0x8D96
        /// </summary>
        BlueInteger = ((int)0x8D96),
        /// <summary>
        /// Original was GL_ALPHA_INTEGER = 0x8D97
        /// </summary>
        AlphaInteger = ((int)0x8D97),
        /// <summary>
        /// Original was GL_RGB_INTEGER = 0x8D98
        /// </summary>
        RgbInteger = ((int)0x8D98),
        /// <summary>
        /// Original was GL_RGBA_INTEGER = 0x8D99
        /// </summary>
        RgbaInteger = ((int)0x8D99),
        /// <summary>
        /// Original was GL_BGR_INTEGER = 0x8D9A
        /// </summary>
        BgrInteger = ((int)0x8D9A),
        /// <summary>
        /// Original was GL_BGRA_INTEGER = 0x8D9B
        /// </summary>
        BgraInteger = ((int)0x8D9B),
    }
    public enum PixelInternalFormat : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_ALPHA = 0x1906
        /// </summary>
        Alpha = ((int)0x1906),
        /// <summary>
        /// Original was GL_RGB = 0x1907
        /// </summary>
        Rgb = ((int)0x1907),
        /// <summary>
        /// Original was GL_RGBA = 0x1908
        /// </summary>
        Rgba = ((int)0x1908),
        /// <summary>
        /// Original was GL_LUMINANCE = 0x1909
        /// </summary>
        Luminance = ((int)0x1909),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA = 0x190A
        /// </summary>
        LuminanceAlpha = ((int)0x190A),
        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = ((int)0x2A10),
        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = ((int)0x803B),
        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = ((int)0x803D),
        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = ((int)0x803E),
        /// <summary>
        /// Original was GL_LUMINANCE4 = 0x803F
        /// </summary>
        Luminance4 = ((int)0x803F),
        /// <summary>
        /// Original was GL_LUMINANCE8 = 0x8040
        /// </summary>
        Luminance8 = ((int)0x8040),
        /// <summary>
        /// Original was GL_LUMINANCE12 = 0x8041
        /// </summary>
        Luminance12 = ((int)0x8041),
        /// <summary>
        /// Original was GL_LUMINANCE16 = 0x8042
        /// </summary>
        Luminance16 = ((int)0x8042),
        /// <summary>
        /// Original was GL_LUMINANCE4_ALPHA4 = 0x8043
        /// </summary>
        Luminance4Alpha4 = ((int)0x8043),
        /// <summary>
        /// Original was GL_LUMINANCE6_ALPHA2 = 0x8044
        /// </summary>
        Luminance6Alpha2 = ((int)0x8044),
        /// <summary>
        /// Original was GL_LUMINANCE8_ALPHA8 = 0x8045
        /// </summary>
        Luminance8Alpha8 = ((int)0x8045),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA4 = 0x8046
        /// </summary>
        Luminance12Alpha4 = ((int)0x8046),
        /// <summary>
        /// Original was GL_LUMINANCE12_ALPHA12 = 0x8047
        /// </summary>
        Luminance12Alpha12 = ((int)0x8047),
        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA16 = 0x8048
        /// </summary>
        Luminance16Alpha16 = ((int)0x8048),
        /// <summary>
        /// Original was GL_INTENSITY = 0x8049
        /// </summary>
        Intensity = ((int)0x8049),
        /// <summary>
        /// Original was GL_INTENSITY4 = 0x804A
        /// </summary>
        Intensity4 = ((int)0x804A),
        /// <summary>
        /// Original was GL_INTENSITY8 = 0x804B
        /// </summary>
        Intensity8 = ((int)0x804B),
        /// <summary>
        /// Original was GL_INTENSITY12 = 0x804C
        /// </summary>
        Intensity12 = ((int)0x804C),
        /// <summary>
        /// Original was GL_INTENSITY16 = 0x804D
        /// </summary>
        Intensity16 = ((int)0x804D),
        /// <summary>
        /// Original was GL_RGB2_EXT = 0x804E
        /// </summary>
        Rgb2Ext = ((int)0x804E),
        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGBA2 = 0x8055
        /// </summary>
        Rgba2 = ((int)0x8055),
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGB5_A1 = 0x8057
        /// </summary>
        Rgb5A1 = ((int)0x8057),
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = ((int)0x805B),
        /// <summary>
        /// Original was GL_DUAL_ALPHA4_SGIS = 0x8110
        /// </summary>
        DualAlpha4Sgis = ((int)0x8110),
        /// <summary>
        /// Original was GL_DUAL_ALPHA8_SGIS = 0x8111
        /// </summary>
        DualAlpha8Sgis = ((int)0x8111),
        /// <summary>
        /// Original was GL_DUAL_ALPHA12_SGIS = 0x8112
        /// </summary>
        DualAlpha12Sgis = ((int)0x8112),
        /// <summary>
        /// Original was GL_DUAL_ALPHA16_SGIS = 0x8113
        /// </summary>
        DualAlpha16Sgis = ((int)0x8113),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE4_SGIS = 0x8114
        /// </summary>
        DualLuminance4Sgis = ((int)0x8114),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE8_SGIS = 0x8115
        /// </summary>
        DualLuminance8Sgis = ((int)0x8115),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE12_SGIS = 0x8116
        /// </summary>
        DualLuminance12Sgis = ((int)0x8116),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE16_SGIS = 0x8117
        /// </summary>
        DualLuminance16Sgis = ((int)0x8117),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY4_SGIS = 0x8118
        /// </summary>
        DualIntensity4Sgis = ((int)0x8118),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY8_SGIS = 0x8119
        /// </summary>
        DualIntensity8Sgis = ((int)0x8119),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY12_SGIS = 0x811A
        /// </summary>
        DualIntensity12Sgis = ((int)0x811A),
        /// <summary>
        /// Original was GL_DUAL_INTENSITY16_SGIS = 0x811B
        /// </summary>
        DualIntensity16Sgis = ((int)0x811B),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA4_SGIS = 0x811C
        /// </summary>
        DualLuminanceAlpha4Sgis = ((int)0x811C),
        /// <summary>
        /// Original was GL_DUAL_LUMINANCE_ALPHA8_SGIS = 0x811D
        /// </summary>
        DualLuminanceAlpha8Sgis = ((int)0x811D),
        /// <summary>
        /// Original was GL_QUAD_ALPHA4_SGIS = 0x811E
        /// </summary>
        QuadAlpha4Sgis = ((int)0x811E),
        /// <summary>
        /// Original was GL_QUAD_ALPHA8_SGIS = 0x811F
        /// </summary>
        QuadAlpha8Sgis = ((int)0x811F),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE4_SGIS = 0x8120
        /// </summary>
        QuadLuminance4Sgis = ((int)0x8120),
        /// <summary>
        /// Original was GL_QUAD_LUMINANCE8_SGIS = 0x8121
        /// </summary>
        QuadLuminance8Sgis = ((int)0x8121),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY4_SGIS = 0x8122
        /// </summary>
        QuadIntensity4Sgis = ((int)0x8122),
        /// <summary>
        /// Original was GL_QUAD_INTENSITY8_SGIS = 0x8123
        /// </summary>
        QuadIntensity8Sgis = ((int)0x8123),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81a5
        /// </summary>
        DepthComponent16 = ((int)0x81a5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16_SGIX = 0x81A5
        /// </summary>
        DepthComponent16Sgix = ((int)0x81A5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81a6
        /// </summary>
        DepthComponent24 = ((int)0x81a6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24_SGIX = 0x81A6
        /// </summary>
        DepthComponent24Sgix = ((int)0x81A6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32 = 0x81a7
        /// </summary>
        DepthComponent32 = ((int)0x81a7),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32_SGIX = 0x81A7
        /// </summary>
        DepthComponent32Sgix = ((int)0x81A7),
        /// <summary>
        /// Original was GL_COMPRESSED_RED = 0x8225
        /// </summary>
        CompressedRed = ((int)0x8225),
        /// <summary>
        /// Original was GL_COMPRESSED_RG = 0x8226
        /// </summary>
        CompressedRg = ((int)0x8226),
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229),
        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = ((int)0x822A),
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = ((int)0x822C),
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D),
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E),
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230),
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231),
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232),
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233),
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234),
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235),
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236),
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237),
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238),
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239),
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A),
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B),
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_S3TC_DXT1_EXT = 0x83F0
        /// </summary>
        CompressedRgbS3tcDxt1Ext = ((int)0x83F0),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT1_EXT = 0x83F1
        /// </summary>
        CompressedRgbaS3tcDxt1Ext = ((int)0x83F1),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT3_EXT = 0x83F2
        /// </summary>
        CompressedRgbaS3tcDxt3Ext = ((int)0x83F2),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_S3TC_DXT5_EXT = 0x83F3
        /// </summary>
        CompressedRgbaS3tcDxt5Ext = ((int)0x83F3),
        /// <summary>
        /// Original was GL_RGB_ICC_SGIX = 0x8460
        /// </summary>
        RgbIccSgix = ((int)0x8460),
        /// <summary>
        /// Original was GL_RGBA_ICC_SGIX = 0x8461
        /// </summary>
        RgbaIccSgix = ((int)0x8461),
        /// <summary>
        /// Original was GL_ALPHA_ICC_SGIX = 0x8462
        /// </summary>
        AlphaIccSgix = ((int)0x8462),
        /// <summary>
        /// Original was GL_LUMINANCE_ICC_SGIX = 0x8463
        /// </summary>
        LuminanceIccSgix = ((int)0x8463),
        /// <summary>
        /// Original was GL_INTENSITY_ICC_SGIX = 0x8464
        /// </summary>
        IntensityIccSgix = ((int)0x8464),
        /// <summary>
        /// Original was GL_LUMINANCE_ALPHA_ICC_SGIX = 0x8465
        /// </summary>
        LuminanceAlphaIccSgix = ((int)0x8465),
        /// <summary>
        /// Original was GL_R5_G6_B5_ICC_SGIX = 0x8466
        /// </summary>
        R5G6B5IccSgix = ((int)0x8466),
        /// <summary>
        /// Original was GL_R5_G6_B5_A8_ICC_SGIX = 0x8467
        /// </summary>
        R5G6B5A8IccSgix = ((int)0x8467),
        /// <summary>
        /// Original was GL_ALPHA16_ICC_SGIX = 0x8468
        /// </summary>
        Alpha16IccSgix = ((int)0x8468),
        /// <summary>
        /// Original was GL_LUMINANCE16_ICC_SGIX = 0x8469
        /// </summary>
        Luminance16IccSgix = ((int)0x8469),
        /// <summary>
        /// Original was GL_INTENSITY16_ICC_SGIX = 0x846A
        /// </summary>
        Intensity16IccSgix = ((int)0x846A),
        /// <summary>
        /// Original was GL_LUMINANCE16_ALPHA8_ICC_SGIX = 0x846B
        /// </summary>
        Luminance16Alpha8IccSgix = ((int)0x846B),
        /// <summary>
        /// Original was GL_COMPRESSED_ALPHA = 0x84E9
        /// </summary>
        CompressedAlpha = ((int)0x84E9),
        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE = 0x84EA
        /// </summary>
        CompressedLuminance = ((int)0x84EA),
        /// <summary>
        /// Original was GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB
        /// </summary>
        CompressedLuminanceAlpha = ((int)0x84EB),
        /// <summary>
        /// Original was GL_COMPRESSED_INTENSITY = 0x84EC
        /// </summary>
        CompressedIntensity = ((int)0x84EC),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB = 0x84ED
        /// </summary>
        CompressedRgb = ((int)0x84ED),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA = 0x84EE
        /// </summary>
        CompressedRgba = ((int)0x84EE),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9),
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815),
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_SRGB = 0x8C40
        /// </summary>
        Srgb = ((int)0x8C40),
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB_ALPHA = 0x8C42
        /// </summary>
        SrgbAlpha = ((int)0x8C42),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43),
        /// <summary>
        /// Original was GL_SLUMINANCE_ALPHA = 0x8C44
        /// </summary>
        SluminanceAlpha = ((int)0x8C44),
        /// <summary>
        /// Original was GL_SLUMINANCE8_ALPHA8 = 0x8C45
        /// </summary>
        Sluminance8Alpha8 = ((int)0x8C45),
        /// <summary>
        /// Original was GL_SLUMINANCE = 0x8C46
        /// </summary>
        Sluminance = ((int)0x8C46),
        /// <summary>
        /// Original was GL_SLUMINANCE8 = 0x8C47
        /// </summary>
        Sluminance8 = ((int)0x8C47),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB = 0x8C48
        /// </summary>
        CompressedSrgb = ((int)0x8C48),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA = 0x8C49
        /// </summary>
        CompressedSrgbAlpha = ((int)0x8C49),
        /// <summary>
        /// Original was GL_COMPRESSED_SLUMINANCE = 0x8C4A
        /// </summary>
        CompressedSluminance = ((int)0x8C4A),
        /// <summary>
        /// Original was GL_COMPRESSED_SLUMINANCE_ALPHA = 0x8C4B
        /// </summary>
        CompressedSluminanceAlpha = ((int)0x8C4B),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_S3TC_DXT1_EXT = 0x8C4C
        /// </summary>
        CompressedSrgbS3tcDxt1Ext = ((int)0x8C4C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT1_EXT = 0x8C4D
        /// </summary>
        CompressedSrgbAlphaS3tcDxt1Ext = ((int)0x8C4D),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT3_EXT = 0x8C4E
        /// </summary>
        CompressedSrgbAlphaS3tcDxt3Ext = ((int)0x8C4E),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_S3TC_DXT5_EXT = 0x8C4F
        /// </summary>
        CompressedSrgbAlphaS3tcDxt5Ext = ((int)0x8C4F),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD),
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70),
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71),
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76),
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77),
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C),
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D),
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82),
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83),
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88),
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89),
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E),
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F),
        /// <summary>
        /// Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        /// </summary>
        Float32UnsignedInt248Rev = ((int)0x8DAD),
        /// <summary>
        /// Original was GL_COMPRESSED_RED_RGTC1 = 0x8DBB
        /// </summary>
        CompressedRedRgtc1 = ((int)0x8DBB),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RED_RGTC1 = 0x8DBC
        /// </summary>
        CompressedSignedRedRgtc1 = ((int)0x8DBC),
        /// <summary>
        /// Original was GL_COMPRESSED_RG_RGTC2 = 0x8DBD
        /// </summary>
        CompressedRgRgtc2 = ((int)0x8DBD),
        /// <summary>
        /// Original was GL_COMPRESSED_SIGNED_RG_RGTC2 = 0x8DBE
        /// </summary>
        CompressedSignedRgRgtc2 = ((int)0x8DBE),
        /// <summary>
        /// Original was GL_COMPRESSED_RGBA_BPTC_UNORM = 0x8E8C
        /// </summary>
        CompressedRgbaBptcUnorm = ((int)0x8E8C),
        /// <summary>
        /// Original was GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM = 0x8E8D
        /// </summary>
        CompressedSrgbAlphaBptcUnorm = ((int)0x8E8D),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT = 0x8E8E
        /// </summary>
        CompressedRgbBptcSignedFloat = ((int)0x8E8E),
        /// <summary>
        /// Original was GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT = 0x8E8F
        /// </summary>
        CompressedRgbBptcUnsignedFloat = ((int)0x8E8F),
        /// <summary>
        /// Original was GL_R8_SNORM = 0x8F94
        /// </summary>
        R8Snorm = ((int)0x8F94),
        /// <summary>
        /// Original was GL_RG8_SNORM = 0x8F95
        /// </summary>
        Rg8Snorm = ((int)0x8F95),
        /// <summary>
        /// Original was GL_RGB8_SNORM = 0x8F96
        /// </summary>
        Rgb8Snorm = ((int)0x8F96),
        /// <summary>
        /// Original was GL_RGBA8_SNORM = 0x8F97
        /// </summary>
        Rgba8Snorm = ((int)0x8F97),
        /// <summary>
        /// Original was GL_R16_SNORM = 0x8F98
        /// </summary>
        R16Snorm = ((int)0x8F98),
        /// <summary>
        /// Original was GL_RG16_SNORM = 0x8F99
        /// </summary>
        Rg16Snorm = ((int)0x8F99),
        /// <summary>
        /// Original was GL_RGB16_SNORM = 0x8F9A
        /// </summary>
        Rgb16Snorm = ((int)0x8F9A),
        /// <summary>
        /// Original was GL_RGBA16_SNORM = 0x8F9B
        /// </summary>
        Rgba16Snorm = ((int)0x8F9B),
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F),
        /// <summary>
        /// Original was GL_ONE = 1
        /// </summary>
        One = ((int)1),
        /// <summary>
        /// Original was GL_TWO = 2
        /// </summary>
        Two = ((int)2),
        /// <summary>
        /// Original was GL_THREE = 3
        /// </summary>
        Three = ((int)3),
        /// <summary>
        /// Original was GL_FOUR = 4
        /// </summary>
        Four = ((int)4),
    }
    public enum PixelStoreParameter : int
    {
        /// <summary>
        /// Original was GL_UNPACK_SWAP_BYTES = 0x0CF0
        /// </summary>
        UnpackSwapBytes = ((int)0x0CF0),
        /// <summary>
        /// Original was GL_UNPACK_LSB_FIRST = 0x0CF1
        /// </summary>
        UnpackLsbFirst = ((int)0x0CF1),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH = 0x0CF2
        /// </summary>
        UnpackRowLength = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_ROW_LENGTH_EXT = 0x0CF2
        /// </summary>
        UnpackRowLengthExt = ((int)0x0CF2),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS = 0x0CF3
        /// </summary>
        UnpackSkipRows = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_ROWS_EXT = 0x0CF3
        /// </summary>
        UnpackSkipRowsExt = ((int)0x0CF3),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS = 0x0CF4
        /// </summary>
        UnpackSkipPixels = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_PIXELS_EXT = 0x0CF4
        /// </summary>
        UnpackSkipPixelsExt = ((int)0x0CF4),
        /// <summary>
        /// Original was GL_UNPACK_ALIGNMENT = 0x0CF5
        /// </summary>
        UnpackAlignment = ((int)0x0CF5),
        /// <summary>
        /// Original was GL_PACK_SWAP_BYTES = 0x0D00
        /// </summary>
        PackSwapBytes = ((int)0x0D00),
        /// <summary>
        /// Original was GL_PACK_LSB_FIRST = 0x0D01
        /// </summary>
        PackLsbFirst = ((int)0x0D01),
        /// <summary>
        /// Original was GL_PACK_ROW_LENGTH = 0x0D02
        /// </summary>
        PackRowLength = ((int)0x0D02),
        /// <summary>
        /// Original was GL_PACK_SKIP_ROWS = 0x0D03
        /// </summary>
        PackSkipRows = ((int)0x0D03),
        /// <summary>
        /// Original was GL_PACK_SKIP_PIXELS = 0x0D04
        /// </summary>
        PackSkipPixels = ((int)0x0D04),
        /// <summary>
        /// Original was GL_PACK_ALIGNMENT = 0x0D05
        /// </summary>
        PackAlignment = ((int)0x0D05),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES = 0x806B
        /// </summary>
        PackSkipImages = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_SKIP_IMAGES_EXT = 0x806B
        /// </summary>
        PackSkipImagesExt = ((int)0x806B),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT = 0x806C
        /// </summary>
        PackImageHeight = ((int)0x806C),
        /// <summary>
        /// Original was GL_PACK_IMAGE_HEIGHT_EXT = 0x806C
        /// </summary>
        PackImageHeightExt = ((int)0x806C),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES = 0x806D
        /// </summary>
        UnpackSkipImages = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_IMAGES_EXT = 0x806D
        /// </summary>
        UnpackSkipImagesExt = ((int)0x806D),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT = 0x806E
        /// </summary>
        UnpackImageHeight = ((int)0x806E),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_HEIGHT_EXT = 0x806E
        /// </summary>
        UnpackImageHeightExt = ((int)0x806E),
        /// <summary>
        /// Original was GL_PACK_SKIP_VOLUMES_SGIS = 0x8130
        /// </summary>
        PackSkipVolumesSgis = ((int)0x8130),
        /// <summary>
        /// Original was GL_PACK_IMAGE_DEPTH_SGIS = 0x8131
        /// </summary>
        PackImageDepthSgis = ((int)0x8131),
        /// <summary>
        /// Original was GL_UNPACK_SKIP_VOLUMES_SGIS = 0x8132
        /// </summary>
        UnpackSkipVolumesSgis = ((int)0x8132),
        /// <summary>
        /// Original was GL_UNPACK_IMAGE_DEPTH_SGIS = 0x8133
        /// </summary>
        UnpackImageDepthSgis = ((int)0x8133),
        /// <summary>
        /// Original was GL_PIXEL_TILE_WIDTH_SGIX = 0x8140
        /// </summary>
        PixelTileWidthSgix = ((int)0x8140),
        /// <summary>
        /// Original was GL_PIXEL_TILE_HEIGHT_SGIX = 0x8141
        /// </summary>
        PixelTileHeightSgix = ((int)0x8141),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_WIDTH_SGIX = 0x8142
        /// </summary>
        PixelTileGridWidthSgix = ((int)0x8142),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_HEIGHT_SGIX = 0x8143
        /// </summary>
        PixelTileGridHeightSgix = ((int)0x8143),
        /// <summary>
        /// Original was GL_PIXEL_TILE_GRID_DEPTH_SGIX = 0x8144
        /// </summary>
        PixelTileGridDepthSgix = ((int)0x8144),
        /// <summary>
        /// Original was GL_PIXEL_TILE_CACHE_SIZE_SGIX = 0x8145
        /// </summary>
        PixelTileCacheSizeSgix = ((int)0x8145),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_SGIX = 0x842E
        /// </summary>
        PackResampleSgix = ((int)0x842E),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_SGIX = 0x842F
        /// </summary>
        UnpackResampleSgix = ((int)0x842F),
        /// <summary>
        /// Original was GL_PACK_SUBSAMPLE_RATE_SGIX = 0x85A0
        /// </summary>
        PackSubsampleRateSgix = ((int)0x85A0),
        /// <summary>
        /// Original was GL_UNPACK_SUBSAMPLE_RATE_SGIX = 0x85A1
        /// </summary>
        UnpackSubsampleRateSgix = ((int)0x85A1),
        /// <summary>
        /// Original was GL_PACK_RESAMPLE_OML = 0x8984
        /// </summary>
        PackResampleOml = ((int)0x8984),
        /// <summary>
        /// Original was GL_UNPACK_RESAMPLE_OML = 0x8985
        /// </summary>
        UnpackResampleOml = ((int)0x8985),
        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127
        /// </summary>
        UnpackCompressedBlockWidth = ((int)0x9127),
        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128
        /// </summary>
        UnpackCompressedBlockHeight = ((int)0x9128),
        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129
        /// </summary>
        UnpackCompressedBlockDepth = ((int)0x9129),
        /// <summary>
        /// Original was GL_UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A
        /// </summary>
        UnpackCompressedBlockSize = ((int)0x912A),
        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_WIDTH = 0x912B
        /// </summary>
        PackCompressedBlockWidth = ((int)0x912B),
        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C
        /// </summary>
        PackCompressedBlockHeight = ((int)0x912C),
        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_DEPTH = 0x912D
        /// </summary>
        PackCompressedBlockDepth = ((int)0x912D),
        /// <summary>
        /// Original was GL_PACK_COMPRESSED_BLOCK_SIZE = 0x912E
        /// </summary>
        PackCompressedBlockSize = ((int)0x912E),
    }
    public enum PixelType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = ((int)0x140B),
        /// <summary>
        /// Original was GL_BITMAP = 0x1A00
        /// </summary>
        Bitmap = ((int)0x1A00),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2 = 0x8032
        /// </summary>
        UnsignedByte332 = ((int)0x8032),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_3_3_2_EXT = 0x8032
        /// </summary>
        UnsignedByte332Ext = ((int)0x8032),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033
        /// </summary>
        UnsignedShort4444 = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_EXT = 0x8033
        /// </summary>
        UnsignedShort4444Ext = ((int)0x8033),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034
        /// </summary>
        UnsignedShort5551 = ((int)0x8034),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_5_5_1_EXT = 0x8034
        /// </summary>
        UnsignedShort5551Ext = ((int)0x8034),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8 = 0x8035
        /// </summary>
        UnsignedInt8888 = ((int)0x8035),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_EXT = 0x8035
        /// </summary>
        UnsignedInt8888Ext = ((int)0x8035),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2 = 0x8036
        /// </summary>
        UnsignedInt1010102 = ((int)0x8036),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10_10_10_2_EXT = 0x8036
        /// </summary>
        UnsignedInt1010102Ext = ((int)0x8036),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE_2_3_3_REVERSED = 0x8362
        /// </summary>
        UnsignedByte233Reversed = ((int)0x8362),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5 = 0x8363
        /// </summary>
        UnsignedShort565 = ((int)0x8363),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_5_6_5_REVERSED = 0x8364
        /// </summary>
        UnsignedShort565Reversed = ((int)0x8364),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_4_4_4_4_REVERSED = 0x8365
        /// </summary>
        UnsignedShort4444Reversed = ((int)0x8365),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT_1_5_5_5_REVERSED = 0x8366
        /// </summary>
        UnsignedShort1555Reversed = ((int)0x8366),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_8_8_8_8_REVERSED = 0x8367
        /// </summary>
        UnsignedInt8888Reversed = ((int)0x8367),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REVERSED = 0x8368
        /// </summary>
        UnsignedInt2101010Reversed = ((int)0x8368),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_24_8 = 0x84FA
        /// </summary>
        UnsignedInt248 = ((int)0x84FA),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = ((int)0x8C3B),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_5_9_9_9_REV = 0x8C3E
        /// </summary>
        UnsignedInt5999Rev = ((int)0x8C3E),
        /// <summary>
        /// Original was GL_FLOAT_32_UNSIGNED_INT_24_8_REV = 0x8DAD
        /// </summary>
        Float32UnsignedInt248Rev = ((int)0x8DAD),
    }
    public enum PolygonMode : int
    {
        /// <summary>
        /// Original was GL_POINT = 0x1B00
        /// </summary>
        Point = ((int)0x1B00),
        /// <summary>
        /// Original was GL_LINE = 0x1B01
        /// </summary>
        Line = ((int)0x1B01),
        /// <summary>
        /// Original was GL_FILL = 0x1B02
        /// </summary>
        Fill = ((int)0x1B02),
    }
    public enum PrimitiveType : int
    {
        /// <summary>
        /// Original was GL_POINTS = 0x0000
        /// </summary>
        Points = ((int)0x0000),
        /// <summary>
        /// Original was GL_LINES = 0x0001
        /// </summary>
        Lines = ((int)0x0001),
        /// <summary>
        /// Original was GL_LINE_LOOP = 0x0002
        /// </summary>
        LineLoop = ((int)0x0002),
        /// <summary>
        /// Original was GL_LINE_STRIP = 0x0003
        /// </summary>
        LineStrip = ((int)0x0003),
        /// <summary>
        /// Original was GL_TRIANGLES = 0x0004
        /// </summary>
        Triangles = ((int)0x0004),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP = 0x0005
        /// </summary>
        TriangleStrip = ((int)0x0005),
        /// <summary>
        /// Original was GL_TRIANGLE_FAN = 0x0006
        /// </summary>
        TriangleFan = ((int)0x0006),
        /// <summary>
        /// Original was GL_QUADS = 0x0007
        /// </summary>
        Quads = ((int)0x0007),
        /// <summary>
        /// Original was GL_QUADS_EXT = 0x0007
        /// </summary>
        QuadsExt = ((int)0x0007),
        /// <summary>
        /// Original was GL_QUAD_STRIP = 0x0008
        /// </summary>
        QuadStrip = ((int)0x0008),
        /// <summary>
        /// Original was GL_POLYGON = 0x0009
        /// </summary>
        Polygon = ((int)0x0009),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY = 0x000A
        /// </summary>
        LinesAdjacency = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_ARB = 0x000A
        /// </summary>
        LinesAdjacencyArb = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINES_ADJACENCY_EXT = 0x000A
        /// </summary>
        LinesAdjacencyExt = ((int)0x000A),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY = 0x000B
        /// </summary>
        LineStripAdjacency = ((int)0x000B),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_ARB = 0x000B
        /// </summary>
        LineStripAdjacencyArb = ((int)0x000B),
        /// <summary>
        /// Original was GL_LINE_STRIP_ADJACENCY_EXT = 0x000B
        /// </summary>
        LineStripAdjacencyExt = ((int)0x000B),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY = 0x000C
        /// </summary>
        TrianglesAdjacency = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_ARB = 0x000C
        /// </summary>
        TrianglesAdjacencyArb = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLES_ADJACENCY_EXT = 0x000C
        /// </summary>
        TrianglesAdjacencyExt = ((int)0x000C),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY = 0x000D
        /// </summary>
        TriangleStripAdjacency = ((int)0x000D),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_ARB = 0x000D
        /// </summary>
        TriangleStripAdjacencyArb = ((int)0x000D),
        /// <summary>
        /// Original was GL_TRIANGLE_STRIP_ADJACENCY_EXT = 0x000D
        /// </summary>
        TriangleStripAdjacencyExt = ((int)0x000D),
        /// <summary>
        /// Original was GL_PATCHES = 0x000E
        /// </summary>
        Patches = ((int)0x000E),
        /// <summary>
        /// Original was GL_PATCHES_EXT = 0x000E
        /// </summary>
        PatchesExt = ((int)0x000E),
    }
    public enum ReadBufferMode : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_FRONT_LEFT = 0x0400
        /// </summary>
        FrontLeft = ((int)0x0400),
        /// <summary>
        /// Original was GL_FRONT_RIGHT = 0x0401
        /// </summary>
        FrontRight = ((int)0x0401),
        /// <summary>
        /// Original was GL_BACK_LEFT = 0x0402
        /// </summary>
        BackLeft = ((int)0x0402),
        /// <summary>
        /// Original was GL_BACK_RIGHT = 0x0403
        /// </summary>
        BackRight = ((int)0x0403),
        /// <summary>
        /// Original was GL_FRONT = 0x0404
        /// </summary>
        Front = ((int)0x0404),
        /// <summary>
        /// Original was GL_BACK = 0x0405
        /// </summary>
        Back = ((int)0x0405),
        /// <summary>
        /// Original was GL_LEFT = 0x0406
        /// </summary>
        Left = ((int)0x0406),
        /// <summary>
        /// Original was GL_RIGHT = 0x0407
        /// </summary>
        Right = ((int)0x0407),
        /// <summary>
        /// Original was GL_FRONT_AND_BACK = 0x0408
        /// </summary>
        FrontAndBack = ((int)0x0408),
        /// <summary>
        /// Original was GL_AUX0 = 0x0409
        /// </summary>
        Aux0 = ((int)0x0409),
        /// <summary>
        /// Original was GL_AUX1 = 0x040A
        /// </summary>
        Aux1 = ((int)0x040A),
        /// <summary>
        /// Original was GL_AUX2 = 0x040B
        /// </summary>
        Aux2 = ((int)0x040B),
        /// <summary>
        /// Original was GL_AUX3 = 0x040C
        /// </summary>
        Aux3 = ((int)0x040C),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT0 = 0x8CE0
        /// </summary>
        ColorAttachment0 = ((int)0x8CE0),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT1 = 0x8CE1
        /// </summary>
        ColorAttachment1 = ((int)0x8CE1),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT2 = 0x8CE2
        /// </summary>
        ColorAttachment2 = ((int)0x8CE2),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT3 = 0x8CE3
        /// </summary>
        ColorAttachment3 = ((int)0x8CE3),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT4 = 0x8CE4
        /// </summary>
        ColorAttachment4 = ((int)0x8CE4),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT5 = 0x8CE5
        /// </summary>
        ColorAttachment5 = ((int)0x8CE5),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT6 = 0x8CE6
        /// </summary>
        ColorAttachment6 = ((int)0x8CE6),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT7 = 0x8CE7
        /// </summary>
        ColorAttachment7 = ((int)0x8CE7),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT8 = 0x8CE8
        /// </summary>
        ColorAttachment8 = ((int)0x8CE8),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT9 = 0x8CE9
        /// </summary>
        ColorAttachment9 = ((int)0x8CE9),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT10 = 0x8CEA
        /// </summary>
        ColorAttachment10 = ((int)0x8CEA),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT11 = 0x8CEB
        /// </summary>
        ColorAttachment11 = ((int)0x8CEB),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT12 = 0x8CEC
        /// </summary>
        ColorAttachment12 = ((int)0x8CEC),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT13 = 0x8CED
        /// </summary>
        ColorAttachment13 = ((int)0x8CED),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT14 = 0x8CEE
        /// </summary>
        ColorAttachment14 = ((int)0x8CEE),
        /// <summary>
        /// Original was GL_COLOR_ATTACHMENT15 = 0x8CEF
        /// </summary>
        ColorAttachment15 = ((int)0x8CEF),
    }
    public enum RenderbufferStorage : int
    {
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT = 0x1902
        /// </summary>
        DepthComponent = ((int)0x1902),
        /// <summary>
        /// Original was GL_R3_G3_B2 = 0x2A10
        /// </summary>
        R3G3B2 = ((int)0x2A10),
        /// <summary>
        /// Original was GL_ALPHA4 = 0x803B
        /// </summary>
        Alpha4 = ((int)0x803B),
        /// <summary>
        /// Original was GL_ALPHA8 = 0x803C
        /// </summary>
        Alpha8 = ((int)0x803C),
        /// <summary>
        /// Original was GL_ALPHA12 = 0x803D
        /// </summary>
        Alpha12 = ((int)0x803D),
        /// <summary>
        /// Original was GL_ALPHA16 = 0x803E
        /// </summary>
        Alpha16 = ((int)0x803E),
        /// <summary>
        /// Original was GL_RGB4 = 0x804F
        /// </summary>
        Rgb4 = ((int)0x804F),
        /// <summary>
        /// Original was GL_RGB5 = 0x8050
        /// </summary>
        Rgb5 = ((int)0x8050),
        /// <summary>
        /// Original was GL_RGB8 = 0x8051
        /// </summary>
        Rgb8 = ((int)0x8051),
        /// <summary>
        /// Original was GL_RGB10 = 0x8052
        /// </summary>
        Rgb10 = ((int)0x8052),
        /// <summary>
        /// Original was GL_RGB12 = 0x8053
        /// </summary>
        Rgb12 = ((int)0x8053),
        /// <summary>
        /// Original was GL_RGB16 = 0x8054
        /// </summary>
        Rgb16 = ((int)0x8054),
        /// <summary>
        /// Original was GL_RGBA2 = 0x8055
        /// </summary>
        Rgba2 = ((int)0x8055),
        /// <summary>
        /// Original was GL_RGBA4 = 0x8056
        /// </summary>
        Rgba4 = ((int)0x8056),
        /// <summary>
        /// Original was GL_RGBA8 = 0x8058
        /// </summary>
        Rgba8 = ((int)0x8058),
        /// <summary>
        /// Original was GL_RGB10_A2 = 0x8059
        /// </summary>
        Rgb10A2 = ((int)0x8059),
        /// <summary>
        /// Original was GL_RGBA12 = 0x805A
        /// </summary>
        Rgba12 = ((int)0x805A),
        /// <summary>
        /// Original was GL_RGBA16 = 0x805B
        /// </summary>
        Rgba16 = ((int)0x805B),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT16 = 0x81a5
        /// </summary>
        DepthComponent16 = ((int)0x81a5),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT24 = 0x81a6
        /// </summary>
        DepthComponent24 = ((int)0x81a6),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32 = 0x81a7
        /// </summary>
        DepthComponent32 = ((int)0x81a7),
        /// <summary>
        /// Original was GL_R8 = 0x8229
        /// </summary>
        R8 = ((int)0x8229),
        /// <summary>
        /// Original was GL_R16 = 0x822A
        /// </summary>
        R16 = ((int)0x822A),
        /// <summary>
        /// Original was GL_RG8 = 0x822B
        /// </summary>
        Rg8 = ((int)0x822B),
        /// <summary>
        /// Original was GL_RG16 = 0x822C
        /// </summary>
        Rg16 = ((int)0x822C),
        /// <summary>
        /// Original was GL_R16F = 0x822D
        /// </summary>
        R16f = ((int)0x822D),
        /// <summary>
        /// Original was GL_R32F = 0x822E
        /// </summary>
        R32f = ((int)0x822E),
        /// <summary>
        /// Original was GL_RG16F = 0x822F
        /// </summary>
        Rg16f = ((int)0x822F),
        /// <summary>
        /// Original was GL_RG32F = 0x8230
        /// </summary>
        Rg32f = ((int)0x8230),
        /// <summary>
        /// Original was GL_R8I = 0x8231
        /// </summary>
        R8i = ((int)0x8231),
        /// <summary>
        /// Original was GL_R8UI = 0x8232
        /// </summary>
        R8ui = ((int)0x8232),
        /// <summary>
        /// Original was GL_R16I = 0x8233
        /// </summary>
        R16i = ((int)0x8233),
        /// <summary>
        /// Original was GL_R16UI = 0x8234
        /// </summary>
        R16ui = ((int)0x8234),
        /// <summary>
        /// Original was GL_R32I = 0x8235
        /// </summary>
        R32i = ((int)0x8235),
        /// <summary>
        /// Original was GL_R32UI = 0x8236
        /// </summary>
        R32ui = ((int)0x8236),
        /// <summary>
        /// Original was GL_RG8I = 0x8237
        /// </summary>
        Rg8i = ((int)0x8237),
        /// <summary>
        /// Original was GL_RG8UI = 0x8238
        /// </summary>
        Rg8ui = ((int)0x8238),
        /// <summary>
        /// Original was GL_RG16I = 0x8239
        /// </summary>
        Rg16i = ((int)0x8239),
        /// <summary>
        /// Original was GL_RG16UI = 0x823A
        /// </summary>
        Rg16ui = ((int)0x823A),
        /// <summary>
        /// Original was GL_RG32I = 0x823B
        /// </summary>
        Rg32i = ((int)0x823B),
        /// <summary>
        /// Original was GL_RG32UI = 0x823C
        /// </summary>
        Rg32ui = ((int)0x823C),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL = 0x84F9
        /// </summary>
        DepthStencil = ((int)0x84F9),
        /// <summary>
        /// Original was GL_RGBA32F = 0x8814
        /// </summary>
        Rgba32f = ((int)0x8814),
        /// <summary>
        /// Original was GL_RGB32F = 0x8815
        /// </summary>
        Rgb32f = ((int)0x8815),
        /// <summary>
        /// Original was GL_RGBA16F = 0x881A
        /// </summary>
        Rgba16f = ((int)0x881A),
        /// <summary>
        /// Original was GL_RGB16F = 0x881B
        /// </summary>
        Rgb16f = ((int)0x881B),
        /// <summary>
        /// Original was GL_DEPTH24_STENCIL8 = 0x88F0
        /// </summary>
        Depth24Stencil8 = ((int)0x88F0),
        /// <summary>
        /// Original was GL_R11F_G11F_B10F = 0x8C3A
        /// </summary>
        R11fG11fB10f = ((int)0x8C3A),
        /// <summary>
        /// Original was GL_RGB9_E5 = 0x8C3D
        /// </summary>
        Rgb9E5 = ((int)0x8C3D),
        /// <summary>
        /// Original was GL_SRGB8 = 0x8C41
        /// </summary>
        Srgb8 = ((int)0x8C41),
        /// <summary>
        /// Original was GL_SRGB8_ALPHA8 = 0x8C43
        /// </summary>
        Srgb8Alpha8 = ((int)0x8C43),
        /// <summary>
        /// Original was GL_DEPTH_COMPONENT32F = 0x8CAC
        /// </summary>
        DepthComponent32f = ((int)0x8CAC),
        /// <summary>
        /// Original was GL_DEPTH32F_STENCIL8 = 0x8CAD
        /// </summary>
        Depth32fStencil8 = ((int)0x8CAD),
        /// <summary>
        /// Original was GL_STENCIL_INDEX1 = 0x8D46
        /// </summary>
        StencilIndex1 = ((int)0x8D46),
        /// <summary>
        /// Original was GL_STENCIL_INDEX1_EXT = 0x8D46
        /// </summary>
        StencilIndex1Ext = ((int)0x8D46),
        /// <summary>
        /// Original was GL_STENCIL_INDEX4 = 0x8D47
        /// </summary>
        StencilIndex4 = ((int)0x8D47),
        /// <summary>
        /// Original was GL_STENCIL_INDEX4_EXT = 0x8D47
        /// </summary>
        StencilIndex4Ext = ((int)0x8D47),
        /// <summary>
        /// Original was GL_STENCIL_INDEX8 = 0x8D48
        /// </summary>
        StencilIndex8 = ((int)0x8D48),
        /// <summary>
        /// Original was GL_STENCIL_INDEX8_EXT = 0x8D48
        /// </summary>
        StencilIndex8Ext = ((int)0x8D48),
        /// <summary>
        /// Original was GL_STENCIL_INDEX16 = 0x8D49
        /// </summary>
        StencilIndex16 = ((int)0x8D49),
        /// <summary>
        /// Original was GL_STENCIL_INDEX16_EXT = 0x8D49
        /// </summary>
        StencilIndex16Ext = ((int)0x8D49),
        /// <summary>
        /// Original was GL_RGBA32UI = 0x8D70
        /// </summary>
        Rgba32ui = ((int)0x8D70),
        /// <summary>
        /// Original was GL_RGB32UI = 0x8D71
        /// </summary>
        Rgb32ui = ((int)0x8D71),
        /// <summary>
        /// Original was GL_RGBA16UI = 0x8D76
        /// </summary>
        Rgba16ui = ((int)0x8D76),
        /// <summary>
        /// Original was GL_RGB16UI = 0x8D77
        /// </summary>
        Rgb16ui = ((int)0x8D77),
        /// <summary>
        /// Original was GL_RGBA8UI = 0x8D7C
        /// </summary>
        Rgba8ui = ((int)0x8D7C),
        /// <summary>
        /// Original was GL_RGB8UI = 0x8D7D
        /// </summary>
        Rgb8ui = ((int)0x8D7D),
        /// <summary>
        /// Original was GL_RGBA32I = 0x8D82
        /// </summary>
        Rgba32i = ((int)0x8D82),
        /// <summary>
        /// Original was GL_RGB32I = 0x8D83
        /// </summary>
        Rgb32i = ((int)0x8D83),
        /// <summary>
        /// Original was GL_RGBA16I = 0x8D88
        /// </summary>
        Rgba16i = ((int)0x8D88),
        /// <summary>
        /// Original was GL_RGB16I = 0x8D89
        /// </summary>
        Rgb16i = ((int)0x8D89),
        /// <summary>
        /// Original was GL_RGBA8I = 0x8D8E
        /// </summary>
        Rgba8i = ((int)0x8D8E),
        /// <summary>
        /// Original was GL_RGB8I = 0x8D8F
        /// </summary>
        Rgb8i = ((int)0x8D8F),
        /// <summary>
        /// Original was GL_RGB10_A2UI = 0x906F
        /// </summary>
        Rgb10A2ui = ((int)0x906F),
    }
    public enum RenderbufferTarget : int
    {
        /// <summary>
        /// Original was GL_RENDERBUFFER = 0x8D41
        /// </summary>
        Renderbuffer = ((int)0x8D41),
        /// <summary>
        /// Original was GL_RENDERBUFFER_EXT = 0x8D41
        /// </summary>
        RenderbufferExt = ((int)0x8D41),
    }
    public enum ShaderParameter : int
    {
        /// <summary>
        /// Original was GL_SHADER_TYPE = 0x8B4F
        /// </summary>
        ShaderType = ((int)0x8B4F),
        /// <summary>
        /// Original was GL_DELETE_STATUS = 0x8B80
        /// </summary>
        DeleteStatus = ((int)0x8B80),
        /// <summary>
        /// Original was GL_COMPILE_STATUS = 0x8B81
        /// </summary>
        CompileStatus = ((int)0x8B81),
        /// <summary>
        /// Original was GL_INFO_LOG_LENGTH = 0x8B84
        /// </summary>
        InfoLogLength = ((int)0x8B84),
        /// <summary>
        /// Original was GL_SHADER_SOURCE_LENGTH = 0x8B88
        /// </summary>
        ShaderSourceLength = ((int)0x8B88),
    }
    public enum ShaderType : int
    {
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER = 0x8B30
        /// </summary>
        FragmentShader = ((int)0x8B30),
        /// <summary>
        /// Original was GL_FRAGMENT_SHADER_ARB = 0x8B30
        /// </summary>
        FragmentShaderArb = ((int)0x8B30),
        /// <summary>
        /// Original was GL_VERTEX_SHADER = 0x8B31
        /// </summary>
        VertexShader = ((int)0x8B31),
        /// <summary>
        /// Original was GL_VERTEX_SHADER_ARB = 0x8B31
        /// </summary>
        VertexShaderArb = ((int)0x8B31),
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER = 0x8DD9
        /// </summary>
        GeometryShader = ((int)0x8DD9),
        /// <summary>
        /// Original was GL_GEOMETRY_SHADER_EXT = 0x8DD9
        /// </summary>
        GeometryShaderExt = ((int)0x8DD9),
        /// <summary>
        /// Original was GL_TESS_EVALUATION_SHADER = 0x8E87
        /// </summary>
        TessEvaluationShader = ((int)0x8E87),
        /// <summary>
        /// Original was GL_TESS_CONTROL_SHADER = 0x8E88
        /// </summary>
        TessControlShader = ((int)0x8E88),
        /// <summary>
        /// Original was GL_COMPUTE_SHADER = 0x91B9
        /// </summary>
        ComputeShader = ((int)0x91B9),
    }
    public enum StringName : int
    {
        /// <summary>
        /// Original was GL_VENDOR = 0x1F00
        /// </summary>
        Vendor = ((int)0x1F00),
        /// <summary>
        /// Original was GL_RENDERER = 0x1F01
        /// </summary>
        Renderer = ((int)0x1F01),
        /// <summary>
        /// Original was GL_VERSION = 0x1F02
        /// </summary>
        Version = ((int)0x1F02),
        /// <summary>
        /// Original was GL_EXTENSIONS = 0x1F03
        /// </summary>
        Extensions = ((int)0x1F03),
        /// <summary>
        /// Original was GL_SHADING_LANGUAGE_VERSION = 0x8B8C
        /// </summary>
        ShadingLanguageVersion = ((int)0x8B8C),
    }
    public enum TextureCompareMode : int
    {
        /// <summary>
        /// Original was GL_NONE = 0
        /// </summary>
        None = ((int)0),
        /// <summary>
        /// Original was GL_COMPARE_REF_TO_TEXTURE = 0x884E
        /// </summary>
        CompareRefToTexture = ((int)0x884E),
        /// <summary>
        /// Original was GL_COMPARE_R_TO_TEXTURE = 0x884E
        /// </summary>
        CompareRToTexture = ((int)0x884E),
    }
    public enum TextureMagFilter : int
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_SGIS = 0x8097
        /// </summary>
        LinearDetailSgis = ((int)0x8097),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_ALPHA_SGIS = 0x8098
        /// </summary>
        LinearDetailAlphaSgis = ((int)0x8098),
        /// <summary>
        /// Original was GL_LINEAR_DETAIL_COLOR_SGIS = 0x8099
        /// </summary>
        LinearDetailColorSgis = ((int)0x8099),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_SGIS = 0x80AD
        /// </summary>
        LinearSharpenSgis = ((int)0x80AD),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_ALPHA_SGIS = 0x80AE
        /// </summary>
        LinearSharpenAlphaSgis = ((int)0x80AE),
        /// <summary>
        /// Original was GL_LINEAR_SHARPEN_COLOR_SGIS = 0x80AF
        /// </summary>
        LinearSharpenColorSgis = ((int)0x80AF),
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = ((int)0x8146),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = ((int)0x8184),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = ((int)0x8185),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = ((int)0x8186),
    }
    public enum TextureMinFilter : int
    {
        /// <summary>
        /// Original was GL_NEAREST = 0x2600
        /// </summary>
        Nearest = ((int)0x2600),
        /// <summary>
        /// Original was GL_LINEAR = 0x2601
        /// </summary>
        Linear = ((int)0x2601),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_NEAREST = 0x2700
        /// </summary>
        NearestMipmapNearest = ((int)0x2700),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_NEAREST = 0x2701
        /// </summary>
        LinearMipmapNearest = ((int)0x2701),
        /// <summary>
        /// Original was GL_NEAREST_MIPMAP_LINEAR = 0x2702
        /// </summary>
        NearestMipmapLinear = ((int)0x2702),
        /// <summary>
        /// Original was GL_LINEAR_MIPMAP_LINEAR = 0x2703
        /// </summary>
        LinearMipmapLinear = ((int)0x2703),
        /// <summary>
        /// Original was GL_FILTER4_SGIS = 0x8146
        /// </summary>
        Filter4Sgis = ((int)0x8146),
        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_LINEAR_SGIX = 0x8170
        /// </summary>
        LinearClipmapLinearSgix = ((int)0x8170),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_CEILING_SGIX = 0x8184
        /// </summary>
        PixelTexGenQCeilingSgix = ((int)0x8184),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_ROUND_SGIX = 0x8185
        /// </summary>
        PixelTexGenQRoundSgix = ((int)0x8185),
        /// <summary>
        /// Original was GL_PIXEL_TEX_GEN_Q_FLOOR_SGIX = 0x8186
        /// </summary>
        PixelTexGenQFloorSgix = ((int)0x8186),
        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_NEAREST_SGIX = 0x844D
        /// </summary>
        NearestClipmapNearestSgix = ((int)0x844D),
        /// <summary>
        /// Original was GL_NEAREST_CLIPMAP_LINEAR_SGIX = 0x844E
        /// </summary>
        NearestClipmapLinearSgix = ((int)0x844E),
        /// <summary>
        /// Original was GL_LINEAR_CLIPMAP_NEAREST_SGIX = 0x844F
        /// </summary>
        LinearClipmapNearestSgix = ((int)0x844F),
    }
    public enum TextureParameterName : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_WIDTH = 0x1000
        /// </summary>
        TextureWidth = ((int)0x1000),
        /// <summary>
        /// Original was GL_TEXTURE_HEIGHT = 0x1001
        /// </summary>
        TextureHeight = ((int)0x1001),
        /// <summary>
        /// Original was GL_TEXTURE_COMPONENTS = 0x1003
        /// </summary>
        TextureComponents = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_INTERNAL_FORMAT = 0x1003
        /// </summary>
        TextureInternalFormat = ((int)0x1003),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR = 0x1004
        /// </summary>
        TextureBorderColor = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER_COLOR_NV = 0x1004
        /// </summary>
        TextureBorderColorNv = ((int)0x1004),
        /// <summary>
        /// Original was GL_TEXTURE_BORDER = 0x1005
        /// </summary>
        TextureBorder = ((int)0x1005),
        /// <summary>
        /// Original was GL_TEXTURE_MAG_FILTER = 0x2800
        /// </summary>
        TextureMagFilter = ((int)0x2800),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_FILTER = 0x2801
        /// </summary>
        TextureMinFilter = ((int)0x2801),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_S = 0x2802
        /// </summary>
        TextureWrapS = ((int)0x2802),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_T = 0x2803
        /// </summary>
        TextureWrapT = ((int)0x2803),
        /// <summary>
        /// Original was GL_TEXTURE_RED_SIZE = 0x805C
        /// </summary>
        TextureRedSize = ((int)0x805C),
        /// <summary>
        /// Original was GL_TEXTURE_GREEN_SIZE = 0x805D
        /// </summary>
        TextureGreenSize = ((int)0x805D),
        /// <summary>
        /// Original was GL_TEXTURE_BLUE_SIZE = 0x805E
        /// </summary>
        TextureBlueSize = ((int)0x805E),
        /// <summary>
        /// Original was GL_TEXTURE_ALPHA_SIZE = 0x805F
        /// </summary>
        TextureAlphaSize = ((int)0x805F),
        /// <summary>
        /// Original was GL_TEXTURE_LUMINANCE_SIZE = 0x8060
        /// </summary>
        TextureLuminanceSize = ((int)0x8060),
        /// <summary>
        /// Original was GL_TEXTURE_INTENSITY_SIZE = 0x8061
        /// </summary>
        TextureIntensitySize = ((int)0x8061),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY = 0x8066
        /// </summary>
        TexturePriority = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_PRIORITY_EXT = 0x8066
        /// </summary>
        TexturePriorityExt = ((int)0x8066),
        /// <summary>
        /// Original was GL_TEXTURE_RESIDENT = 0x8067
        /// </summary>
        TextureResident = ((int)0x8067),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH = 0x8071
        /// </summary>
        TextureDepth = ((int)0x8071),
        /// <summary>
        /// Original was GL_TEXTURE_DEPTH_EXT = 0x8071
        /// </summary>
        TextureDepthExt = ((int)0x8071),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R = 0x8072
        /// </summary>
        TextureWrapR = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_EXT = 0x8072
        /// </summary>
        TextureWrapRExt = ((int)0x8072),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_R_OES = 0x8072
        /// </summary>
        TextureWrapROes = ((int)0x8072),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_LEVEL_SGIS = 0x809A
        /// </summary>
        DetailTextureLevelSgis = ((int)0x809A),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_MODE_SGIS = 0x809B
        /// </summary>
        DetailTextureModeSgis = ((int)0x809B),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS = 0x809C
        /// </summary>
        DetailTextureFuncPointsSgis = ((int)0x809C),
        /// <summary>
        /// Original was GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS = 0x80B0
        /// </summary>
        SharpenTextureFuncPointsSgis = ((int)0x80B0),
        /// <summary>
        /// Original was GL_SHADOW_AMBIENT_SGIX = 0x80BF
        /// </summary>
        ShadowAmbientSgix = ((int)0x80BF),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FAIL_VALUE = 0x80BF
        /// </summary>
        TextureCompareFailValue = ((int)0x80BF),
        /// <summary>
        /// Original was GL_DUAL_TEXTURE_SELECT_SGIS = 0x8124
        /// </summary>
        DualTextureSelectSgis = ((int)0x8124),
        /// <summary>
        /// Original was GL_QUAD_TEXTURE_SELECT_SGIS = 0x8125
        /// </summary>
        QuadTextureSelectSgis = ((int)0x8125),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F),
        /// <summary>
        /// Original was GL_TEXTURE_4DSIZE_SGIS = 0x8136
        /// </summary>
        Texture4DsizeSgis = ((int)0x8136),
        /// <summary>
        /// Original was GL_TEXTURE_WRAP_Q_SGIS = 0x8137
        /// </summary>
        TextureWrapQSgis = ((int)0x8137),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD = 0x813A
        /// </summary>
        TextureMinLod = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MIN_LOD_SGIS = 0x813A
        /// </summary>
        TextureMinLodSgis = ((int)0x813A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD = 0x813B
        /// </summary>
        TextureMaxLod = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LOD_SGIS = 0x813B
        /// </summary>
        TextureMaxLodSgis = ((int)0x813B),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL = 0x813C
        /// </summary>
        TextureBaseLevel = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_BASE_LEVEL_SGIS = 0x813C
        /// </summary>
        TextureBaseLevelSgis = ((int)0x813C),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL = 0x813D
        /// </summary>
        TextureMaxLevel = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_LEVEL_SGIS = 0x813D
        /// </summary>
        TextureMaxLevelSgis = ((int)0x813D),
        /// <summary>
        /// Original was GL_TEXTURE_FILTER4_SIZE_SGIS = 0x8147
        /// </summary>
        TextureFilter4SizeSgis = ((int)0x8147),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_CENTER_SGIX = 0x8171
        /// </summary>
        TextureClipmapCenterSgix = ((int)0x8171),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_FRAME_SGIX = 0x8172
        /// </summary>
        TextureClipmapFrameSgix = ((int)0x8172),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_OFFSET_SGIX = 0x8173
        /// </summary>
        TextureClipmapOffsetSgix = ((int)0x8173),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX = 0x8174
        /// </summary>
        TextureClipmapVirtualDepthSgix = ((int)0x8174),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX = 0x8175
        /// </summary>
        TextureClipmapLodOffsetSgix = ((int)0x8175),
        /// <summary>
        /// Original was GL_TEXTURE_CLIPMAP_DEPTH_SGIX = 0x8176
        /// </summary>
        TextureClipmapDepthSgix = ((int)0x8176),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_BIAS_SGIX = 0x8179
        /// </summary>
        PostTextureFilterBiasSgix = ((int)0x8179),
        /// <summary>
        /// Original was GL_POST_TEXTURE_FILTER_SCALE_SGIX = 0x817A
        /// </summary>
        PostTextureFilterScaleSgix = ((int)0x817A),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_S_SGIX = 0x818E
        /// </summary>
        TextureLodBiasSSgix = ((int)0x818E),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_T_SGIX = 0x818F
        /// </summary>
        TextureLodBiasTSgix = ((int)0x818F),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS_R_SGIX = 0x8190
        /// </summary>
        TextureLodBiasRSgix = ((int)0x8190),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP = 0x8191
        /// </summary>
        GenerateMipmap = ((int)0x8191),
        /// <summary>
        /// Original was GL_GENERATE_MIPMAP_SGIS = 0x8191
        /// </summary>
        GenerateMipmapSgis = ((int)0x8191),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_SGIX = 0x819A
        /// </summary>
        TextureCompareSgix = ((int)0x819A),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B
        /// </summary>
        TextureCompareOperatorSgix = ((int)0x819B),
        /// <summary>
        /// Original was GL_TEXTURE_LEQUAL_R_SGIX = 0x819C
        /// </summary>
        TextureLequalRSgix = ((int)0x819C),
        /// <summary>
        /// Original was GL_TEXTURE_GEQUAL_R_SGIX = 0x819D
        /// </summary>
        TextureGequalRSgix = ((int)0x819D),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_S_SGIX = 0x8369
        /// </summary>
        TextureMaxClampSSgix = ((int)0x8369),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_T_SGIX = 0x836A
        /// </summary>
        TextureMaxClampTSgix = ((int)0x836A),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_CLAMP_R_SGIX = 0x836B
        /// </summary>
        TextureMaxClampRSgix = ((int)0x836B),
        /// <summary>
        /// Original was GL_TEXTURE_MAX_ANISOTROPY = 0x84FE
        /// </summary>
        TextureMaxAnisotropy = ((int)0x84FE),
        /// <summary>
        /// Original was GL_TEXTURE_LOD_BIAS = 0x8501
        /// </summary>
        TextureLodBias = ((int)0x8501),
        /// <summary>
        /// Original was GL_DEPTH_TEXTURE_MODE = 0x884B
        /// </summary>
        DepthTextureMode = ((int)0x884B),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_MODE = 0x884C
        /// </summary>
        TextureCompareMode = ((int)0x884C),
        /// <summary>
        /// Original was GL_TEXTURE_COMPARE_FUNC = 0x884D
        /// </summary>
        TextureCompareFunc = ((int)0x884D),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_R = 0x8E42
        /// </summary>
        TextureSwizzleR = ((int)0x8E42),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_G = 0x8E43
        /// </summary>
        TextureSwizzleG = ((int)0x8E43),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_B = 0x8E44
        /// </summary>
        TextureSwizzleB = ((int)0x8E44),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_A = 0x8E45
        /// </summary>
        TextureSwizzleA = ((int)0x8E45),
        /// <summary>
        /// Original was GL_TEXTURE_SWIZZLE_RGBA = 0x8E46
        /// </summary>
        TextureSwizzleRgba = ((int)0x8E46),
        /// <summary>
        /// Original was GL_DEPTH_STENCIL_TEXTURE_MODE = 0x90EA
        /// </summary>
        DepthStencilTextureMode = ((int)0x90EA),
        /// <summary>
        /// Original was GL_TEXTURE_TILING_EXT = 0x9580
        /// </summary>
        TextureTilingExt = ((int)0x9580),
    }
    public enum TextureTarget : int
    {
        /// <summary>
        /// Original was GL_TEXTURE_1D = 0x0DE0
        /// </summary>
        Texture1D = ((int)0x0DE0),
        /// <summary>
        /// Original was GL_TEXTURE_2D = 0x0DE1
        /// </summary>
        Texture2D = ((int)0x0DE1),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D = 0x8063
        /// </summary>
        ProxyTexture1D = ((int)0x8063),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_EXT = 0x8063
        /// </summary>
        ProxyTexture1DExt = ((int)0x8063),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D = 0x8064
        /// </summary>
        ProxyTexture2D = ((int)0x8064),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_EXT = 0x8064
        /// </summary>
        ProxyTexture2DExt = ((int)0x8064),
        /// <summary>
        /// Original was GL_TEXTURE_3D = 0x806F
        /// </summary>
        Texture3D = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_3D_EXT = 0x806F
        /// </summary>
        Texture3DExt = ((int)0x806F),
        /// <summary>
        /// Original was GL_TEXTURE_3D_OES = 0x806F
        /// </summary>
        Texture3DOes = ((int)0x806F),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D = 0x8070
        /// </summary>
        ProxyTexture3D = ((int)0x8070),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_3D_EXT = 0x8070
        /// </summary>
        ProxyTexture3DExt = ((int)0x8070),
        /// <summary>
        /// Original was GL_DETAIL_TEXTURE_2D_SGIS = 0x8095
        /// </summary>
        DetailTexture2DSgis = ((int)0x8095),
        /// <summary>
        /// Original was GL_TEXTURE_4D_SGIS = 0x8134
        /// </summary>
        Texture4DSgis = ((int)0x8134),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_4D_SGIS = 0x8135
        /// </summary>
        ProxyTexture4DSgis = ((int)0x8135),
        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE = 0x84F5
        /// </summary>
        TextureRectangle = ((int)0x84F5),
        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE_ARB = 0x84F5
        /// </summary>
        TextureRectangleArb = ((int)0x84F5),
        /// <summary>
        /// Original was GL_TEXTURE_RECTANGLE_NV = 0x84F5
        /// </summary>
        TextureRectangleNv = ((int)0x84F5),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE = 0x84F7
        /// </summary>
        ProxyTextureRectangle = ((int)0x84F7),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_ARB = 0x84F7
        /// </summary>
        ProxyTextureRectangleArb = ((int)0x84F7),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7
        /// </summary>
        ProxyTextureRectangleNv = ((int)0x84F7),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP = 0x8513
        /// </summary>
        TextureCubeMap = ((int)0x8513),
        /// <summary>
        /// Original was GL_TEXTURE_BINDING_CUBE_MAP = 0x8514
        /// </summary>
        TextureBindingCubeMap = ((int)0x8514),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515
        /// </summary>
        TextureCubeMapPositiveX = ((int)0x8515),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516
        /// </summary>
        TextureCubeMapNegativeX = ((int)0x8516),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517
        /// </summary>
        TextureCubeMapPositiveY = ((int)0x8517),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518
        /// </summary>
        TextureCubeMapNegativeY = ((int)0x8518),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519
        /// </summary>
        TextureCubeMapPositiveZ = ((int)0x8519),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A
        /// </summary>
        TextureCubeMapNegativeZ = ((int)0x851A),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP = 0x851B
        /// </summary>
        ProxyTextureCubeMap = ((int)0x851B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B
        /// </summary>
        ProxyTextureCubeMapArb = ((int)0x851B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_EXT = 0x851B
        /// </summary>
        ProxyTextureCubeMapExt = ((int)0x851B),
        /// <summary>
        /// Original was GL_TEXTURE_1D_ARRAY = 0x8C18
        /// </summary>
        Texture1DArray = ((int)0x8C18),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY = 0x8C19
        /// </summary>
        ProxyTexture1DArray = ((int)0x8C19),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_1D_ARRAY_EXT = 0x8C19
        /// </summary>
        ProxyTexture1DArrayExt = ((int)0x8C19),
        /// <summary>
        /// Original was GL_TEXTURE_2D_ARRAY = 0x8C1A
        /// </summary>
        Texture2DArray = ((int)0x8C1A),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY = 0x8C1B
        /// </summary>
        ProxyTexture2DArray = ((int)0x8C1B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_ARRAY_EXT = 0x8C1B
        /// </summary>
        ProxyTexture2DArrayExt = ((int)0x8C1B),
        /// <summary>
        /// Original was GL_TEXTURE_BUFFER = 0x8C2A
        /// </summary>
        TextureBuffer = ((int)0x8C2A),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY = 0x9009
        /// </summary>
        TextureCubeMapArray = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x9009
        /// </summary>
        TextureCubeMapArrayArb = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_EXT = 0x9009
        /// </summary>
        TextureCubeMapArrayExt = ((int)0x9009),
        /// <summary>
        /// Original was GL_TEXTURE_CUBE_MAP_ARRAY_OES = 0x9009
        /// </summary>
        TextureCubeMapArrayOes = ((int)0x9009),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B
        /// </summary>
        ProxyTextureCubeMapArray = ((int)0x900B),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB = 0x900B
        /// </summary>
        ProxyTextureCubeMapArrayArb = ((int)0x900B),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE = 0x9100
        /// </summary>
        Texture2DMultisample = ((int)0x9100),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE = 0x9101
        /// </summary>
        ProxyTexture2DMultisample = ((int)0x9101),
        /// <summary>
        /// Original was GL_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102
        /// </summary>
        Texture2DMultisampleArray = ((int)0x9102),
        /// <summary>
        /// Original was GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103
        /// </summary>
        ProxyTexture2DMultisampleArray = ((int)0x9103),
    }
    public enum TextureUnit : int
    {
        /// <summary>
        /// Original was GL_TEXTURE0 = 0x84C0
        /// </summary>
        Texture0 = ((int)0x84C0),
        /// <summary>
        /// Original was GL_TEXTURE1 = 0x84C1
        /// </summary>
        Texture1 = ((int)0x84C1),
        /// <summary>
        /// Original was GL_TEXTURE2 = 0x84C2
        /// </summary>
        Texture2 = ((int)0x84C2),
        /// <summary>
        /// Original was GL_TEXTURE3 = 0x84C3
        /// </summary>
        Texture3 = ((int)0x84C3),
        /// <summary>
        /// Original was GL_TEXTURE4 = 0x84C4
        /// </summary>
        Texture4 = ((int)0x84C4),
        /// <summary>
        /// Original was GL_TEXTURE5 = 0x84C5
        /// </summary>
        Texture5 = ((int)0x84C5),
        /// <summary>
        /// Original was GL_TEXTURE6 = 0x84C6
        /// </summary>
        Texture6 = ((int)0x84C6),
        /// <summary>
        /// Original was GL_TEXTURE7 = 0x84C7
        /// </summary>
        Texture7 = ((int)0x84C7),
        /// <summary>
        /// Original was GL_TEXTURE8 = 0x84C8
        /// </summary>
        Texture8 = ((int)0x84C8),
        /// <summary>
        /// Original was GL_TEXTURE9 = 0x84C9
        /// </summary>
        Texture9 = ((int)0x84C9),
        /// <summary>
        /// Original was GL_TEXTURE10 = 0x84CA
        /// </summary>
        Texture10 = ((int)0x84CA),
        /// <summary>
        /// Original was GL_TEXTURE11 = 0x84CB
        /// </summary>
        Texture11 = ((int)0x84CB),
        /// <summary>
        /// Original was GL_TEXTURE12 = 0x84CC
        /// </summary>
        Texture12 = ((int)0x84CC),
        /// <summary>
        /// Original was GL_TEXTURE13 = 0x84CD
        /// </summary>
        Texture13 = ((int)0x84CD),
        /// <summary>
        /// Original was GL_TEXTURE14 = 0x84CE
        /// </summary>
        Texture14 = ((int)0x84CE),
        /// <summary>
        /// Original was GL_TEXTURE15 = 0x84CF
        /// </summary>
        Texture15 = ((int)0x84CF),
        /// <summary>
        /// Original was GL_TEXTURE16 = 0x84D0
        /// </summary>
        Texture16 = ((int)0x84D0),
        /// <summary>
        /// Original was GL_TEXTURE17 = 0x84D1
        /// </summary>
        Texture17 = ((int)0x84D1),
        /// <summary>
        /// Original was GL_TEXTURE18 = 0x84D2
        /// </summary>
        Texture18 = ((int)0x84D2),
        /// <summary>
        /// Original was GL_TEXTURE19 = 0x84D3
        /// </summary>
        Texture19 = ((int)0x84D3),
        /// <summary>
        /// Original was GL_TEXTURE20 = 0x84D4
        /// </summary>
        Texture20 = ((int)0x84D4),
        /// <summary>
        /// Original was GL_TEXTURE21 = 0x84D5
        /// </summary>
        Texture21 = ((int)0x84D5),
        /// <summary>
        /// Original was GL_TEXTURE22 = 0x84D6
        /// </summary>
        Texture22 = ((int)0x84D6),
        /// <summary>
        /// Original was GL_TEXTURE23 = 0x84D7
        /// </summary>
        Texture23 = ((int)0x84D7),
        /// <summary>
        /// Original was GL_TEXTURE24 = 0x84D8
        /// </summary>
        Texture24 = ((int)0x84D8),
        /// <summary>
        /// Original was GL_TEXTURE25 = 0x84D9
        /// </summary>
        Texture25 = ((int)0x84D9),
        /// <summary>
        /// Original was GL_TEXTURE26 = 0x84DA
        /// </summary>
        Texture26 = ((int)0x84DA),
        /// <summary>
        /// Original was GL_TEXTURE27 = 0x84DB
        /// </summary>
        Texture27 = ((int)0x84DB),
        /// <summary>
        /// Original was GL_TEXTURE28 = 0x84DC
        /// </summary>
        Texture28 = ((int)0x84DC),
        /// <summary>
        /// Original was GL_TEXTURE29 = 0x84DD
        /// </summary>
        Texture29 = ((int)0x84DD),
        /// <summary>
        /// Original was GL_TEXTURE30 = 0x84DE
        /// </summary>
        Texture30 = ((int)0x84DE),
        /// <summary>
        /// Original was GL_TEXTURE31 = 0x84DF
        /// </summary>
        Texture31 = ((int)0x84DF),
    }
    public enum TextureWrapMode : int
    {
        /// <summary>
        /// Original was GL_CLAMP = 0x2900
        /// </summary>
        Clamp = ((int)0x2900),
        /// <summary>
        /// Original was GL_REPEAT = 0x2901
        /// </summary>
        Repeat = ((int)0x2901),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER = 0x812D
        /// </summary>
        ClampToBorder = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_ARB = 0x812D
        /// </summary>
        ClampToBorderArb = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_NV = 0x812D
        /// </summary>
        ClampToBorderNv = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_BORDER_SGIS = 0x812D
        /// </summary>
        ClampToBorderSgis = ((int)0x812D),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE = 0x812F
        /// </summary>
        ClampToEdge = ((int)0x812F),
        /// <summary>
        /// Original was GL_CLAMP_TO_EDGE_SGIS = 0x812F
        /// </summary>
        ClampToEdgeSgis = ((int)0x812F),
        /// <summary>
        /// Original was GL_MIRRORED_REPEAT = 0x8370
        /// </summary>
        MirroredRepeat = ((int)0x8370),
    }
    public enum VertexAttribIntegerType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
    }
    public enum VertexAttribPointerType : int
    {
        /// <summary>
        /// Original was GL_BYTE = 0x1400
        /// </summary>
        Byte = ((int)0x1400),
        /// <summary>
        /// Original was GL_UNSIGNED_BYTE = 0x1401
        /// </summary>
        UnsignedByte = ((int)0x1401),
        /// <summary>
        /// Original was GL_SHORT = 0x1402
        /// </summary>
        Short = ((int)0x1402),
        /// <summary>
        /// Original was GL_UNSIGNED_SHORT = 0x1403
        /// </summary>
        UnsignedShort = ((int)0x1403),
        /// <summary>
        /// Original was GL_INT = 0x1404
        /// </summary>
        Int = ((int)0x1404),
        /// <summary>
        /// Original was GL_UNSIGNED_INT = 0x1405
        /// </summary>
        UnsignedInt = ((int)0x1405),
        /// <summary>
        /// Original was GL_FLOAT = 0x1406
        /// </summary>
        Float = ((int)0x1406),
        /// <summary>
        /// Original was GL_DOUBLE = 0x140A
        /// </summary>
        Double = ((int)0x140A),
        /// <summary>
        /// Original was GL_HALF_FLOAT = 0x140B
        /// </summary>
        HalfFloat = ((int)0x140B),
        /// <summary>
        /// Original was GL_FIXED = 0x140C
        /// </summary>
        Fixed = ((int)0x140C),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368
        /// </summary>
        UnsignedInt2101010Rev = ((int)0x8368),
        /// <summary>
        /// Original was GL_UNSIGNED_INT_10F_11F_11F_REV = 0x8C3B
        /// </summary>
        UnsignedInt10F11F11FRev = ((int)0x8C3B),
        /// <summary>
        /// Original was GL_INT_2_10_10_10_REV = 0x8D9F
        /// </summary>
        Int2101010Rev = ((int)0x8D9F),
    }

    /// <summary>Generic GL enum subset used by LibRender2.</summary>
    public enum All : int
    {
        One = 1,
        Lequal = ((int)0x0203),
        Red = ((int)0x1903),
    }

    /// <summary>Minimal placeholder; only used as a cast target in LibRender2.</summary>
    public enum GetPName : int
    {
    }
}
