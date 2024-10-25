using System;
using System.Drawing;
using System.Windows.Forms;
public class Rectangulo
{
    public Punto PuntoInicial { get; set; }
    public Punto PuntoFinal { get; set; }
    public Color Color { get; set; }

    public Rectangulo(Punto p1, Punto p2, Color c)
    {
        this.PuntoInicial = p1;
        this.PuntoFinal = p2;
        this.Color = c;
    }

    public void Dibujar(Graphics graphics)
    {
        using (Brush brush = new SolidBrush(this.Color))
        {
            // Dibujar el rectángulo
            graphics.FillRectangle(brush,
                (float)Math.Min(PuntoInicial.X, PuntoFinal.X),
                (float)Math.Min(PuntoInicial.Y, PuntoFinal.Y),
                (float)Math.Abs(PuntoFinal.X - PuntoInicial.X),
                (float)Math.Abs(PuntoFinal.Y - PuntoInicial.Y));
        }

        
    }
}