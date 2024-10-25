using System;
using System.Drawing;
using System.Windows.Forms;

namespace csharp_geometria;

public partial class Form1 : Form
{
    private Rectangulo rectangulo;

    public Form1()
    {
        // Crea un rectángulo rojo
        this.rectangulo = new Rectangulo( new Punto(50, 50), new Punto(250, 150), Color.Blue);
#pragma warning disable CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
        this.Paint += new PaintEventHandler(Form1_Paint);
#pragma warning restore CS8622 // Nullability of reference types in type of parameter doesn't match the target delegate (possibly because of nullability attributes).
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        rectangulo.Dibujar(e.Graphics);
    }
    
}
