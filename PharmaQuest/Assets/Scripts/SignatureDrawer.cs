using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class SignatureDrawer : MonoBehaviour
{
    public RawImage espacioFirma;
    private Texture2D texture;
    private Color drawColor = Color.black;
    private Vector2 lastMousePosition;
    public float grosorTrazo = 5f;


    void Start()
    {
        texture = new Texture2D((int)espacioFirma.rectTransform.rect.width, (int)espacioFirma.rectTransform.rect.height);
        espacioFirma.texture = texture;
        ClearTexture();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Input.mousePosition;
            Vector2 localPos;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(espacioFirma.rectTransform, mousePos, null, out localPos);
            localPos += new Vector2(espacioFirma.rectTransform.rect.width / 2, espacioFirma.rectTransform.rect.height / 2);
            localPos = new Vector2(localPos.x, localPos.y) * (texture.width / espacioFirma.rectTransform.rect.width);
            Draw(localPos);
        }
    }

    void Draw(Vector2 position)
    {
        int radius = Mathf.CeilToInt(grosorTrazo / 2);
        int x0 = Mathf.Clamp((int)position.x, radius, texture.width - radius);
        int y0 = Mathf.Clamp((int)position.y, radius, texture.height - radius);

        for (int x = -radius; x < radius; x++)
        {
            for (int y = -radius; y < radius; y++)
            {
                if (x * x + y * y <= radius * radius)
                {
                    int px = x0 + x;
                    int py = y0 + y;

                    if (px >= 0 && px < texture.width && py >= 0 && py < texture.height)
                    {
                        texture.SetPixel(px, py, drawColor);
                    }
                }
            }
        }
        texture.Apply();
    }

    public void ClearTexture()
    {
        Color[] pixels = texture.GetPixels();
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = Color.white;
        }
        texture.SetPixels(pixels);
        texture.Apply();
    }

    public void SaveSignature()
    {
        byte[] bytes = texture.EncodeToPNG();
        
        string customPath = "C://Users/johan/OneDrive/Desktop/Firmas/signature.png";

        string directoryPath = Path.GetDirectoryName(customPath);
        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }

        File.WriteAllBytes(customPath, bytes);
        Debug.Log("Signature saved to: " + customPath);
    }

}

