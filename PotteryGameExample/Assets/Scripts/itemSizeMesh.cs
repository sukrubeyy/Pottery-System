using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSizeMesh : MonoBehaviour
{
    [SerializeField] private SkinnedMeshRenderer skinnnedMesh;
    float skinheight = 2.01932f;
    public void HitSizeMesh(int keyindex, float damageSize)
    {
        //                 Yüksekliği değişecek obje weight   +      0.3f damageSize * (100f/ColliderYSize)            
        float newYHeight = skinnnedMesh.GetBlendShapeWeight(keyindex) + damageSize * (100f/ skinheight);
        //Yukarıda newYHeight değerine yüksekliği değişecek obje hangisi ise parametresini knifeMovement içerisinde 
        //keyindex olarak gönderiyoruz ve damage bilgisini parametre olarak gönderiyoruz.
        //daha sonra bu objenin yüksekliği + damageSize collider'ın yüksekliği olan skinheight 'ın yüze bölümü ile
        //çarpılıyor. skinheight bıçağın ona her temas ettiğinde küçülmektedir.
      

        //Aşşağıda yer alan setBlendShapeWeight' e boyutu değişmesi gereken objenin indexini ve yeni boyutunu
        //parametre olarak gönderiyoruz.
        skinnnedMesh.SetBlendShapeWeight(keyindex, newYHeight);
    }
}
