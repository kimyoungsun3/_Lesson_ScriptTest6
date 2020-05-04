Shader "ZShaderTest/501_FirstShader/OnlyColor"
{
	Properties
	{
		_Float("_Float", Float)			= 0
		_float("_float", float)			= 0
		_Range("_Range", Range(0, 1))	= 0.5
		_range("_range", range(0, 1))	= 0.5
		_Int ("_Int", Int)				= 0
		_int ("_int", int)				= 0
		_Color("_Color", Color)			= (1, 0, 0, 1)
		_color("_color", color)			= (1, 0, 0, 1)
		_Vector("_Vector", Vector)		= (1, 2, 3, 4)
		_vector("_vector", vector)		= (1, 2, 3, 4)
		_2D("_2D", 2D)					= "white" {} 
		
		
	}

	SubShader
	{
		Tags {"RenderType"="Opaque"}
		LOD 200

		CGPROGRAM
		#pragma surface surf Standard fullforwardshadows
		#pragma target 3.0

		struct Input{
			float2 uv_MAINTEX;
		};

		float4 _Color;
		float3 _Color2;
		float _colorR;
		float _colorG;
		float _colorB;
		float _colorPlus;
		void surf(Input IN, inout SurfaceOutputStandard o){

			_Color2 = 1 - _Color;
			o.Albedo = _Color2;
			//_colorPlus = 0.2;

			//_colorR = 0.5 + _colorPlus;
			//_colorG = 0;
			//_colorB = 0.5 + _colorPlus;

			//_Color2 = float3(_colorR, _colorG, _colorB);
			//_Color2 = 1 - _Color2;
			//o.Albedo = _Color2;

			//o.Albedo = _Color.rgb;
			//o.Albedo = float3(0, 0, 0);
			//o.Albedo = float3(0.5f, 0, 0);
			//o.Alpha = .5f;

			//_Color2 = float3(1, 0, 0);
			//o.Albedo = _Color2;
		}
		ENDCG	
	}

	Fallback "Diffuse"

}