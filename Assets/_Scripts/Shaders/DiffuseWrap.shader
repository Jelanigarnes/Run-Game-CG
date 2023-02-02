Shader "Custom/DiffuseWrap"
{
    Properties
    {
      
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _BumpMap ("Bumpmap", 2D) = "bump" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
       

        CGPROGRAM
       
        #pragma surface surf WrapLambert

       
        sampler2D _MainTex;
        sampler2D _BumpMap;

        half4 LightingWrapLambert (SurfaceOutput s, half3 lightDir, half atten) {
        half NdotL = dot (s.Normal, lightDir);
        half diff = NdotL * 0.5 + 0.5;
        half4 c;
        c.rgb = s.Albedo * _LightColor0.rgb * (diff * atten);
        c.a = s.Alpha;
        return c;
        }

        struct Input
        {
            float2 uv_MainTex;
             float2 uv_BumpMap;
        };

      

      

        void surf (Input IN, inout SurfaceOutput o)
        {
           o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
            o.Normal = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap));
        }
        ENDCG
    }
    FallBack "Diffuse"
}
