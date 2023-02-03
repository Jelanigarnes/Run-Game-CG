using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenCameraShader : MonoBehaviour
{
    //public Shader awesomeShader = null;
    public List<Material> m_renderMaterial = new List<Material>();

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
       
            Graphics.Blit(source, destination, m_renderMaterial[0]);
        
            
    }


}
