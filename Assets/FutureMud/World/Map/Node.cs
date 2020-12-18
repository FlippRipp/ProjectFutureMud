using UnityEngine;
using Shapes;

public class Node : MonoBehaviour
{
    public Rectangle outline;
    public Rectangle background;

    public Node northNode;
    public Node westNode; 
    public Node southNode;
    public Node eastNode;
    
    public TextAsset eventText;
    
    public void ChangeBackgroundColor(Color color)
    {
        outline.Color = color;
    }

    public void ChangeOutlineColor(Color color)
    {
        background.Color = color;
    }
}
