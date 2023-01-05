using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VignetteEffect : MonoBehaviour
{
    public Material vignetteMaterial;
    public float fadeDuration = 1.0f;
    public bool vignetteEnabled = false;

    private float vignetteAlpha = 0.0f;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (vignetteEnabled)
        {
            vignetteMaterial.SetFloat("_VignetteAlpha", vignetteAlpha);
            Graphics.Blit(source, destination, vignetteMaterial);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }

    IEnumerator FadeVignette(float targetAlpha)
    {
        float startAlpha = vignetteAlpha;
        float elapsedTime = 0.0f;

        while (elapsedTime < fadeDuration)
        {
            vignetteAlpha = Mathf.Lerp(startAlpha, targetAlpha, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        vignetteAlpha = targetAlpha;
    }

    public void ShowVignette()
    {
        vignetteEnabled = true;
        StartCoroutine(FadeVignette(1.0f));
    }

    public void HideVignette()
    {
        vignetteEnabled = false;
        StartCoroutine(FadeVignette(0.0f));
    }
}
