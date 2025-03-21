namespace EjemplosMAUI.Elementos
{
    internal class DibujoReloj : IDrawable
    {
        public DibujoReloj()
        {
            
        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            DateTime tiempoActual = DateTime.Now;
            var centroReloj = new PointF(200, 300);
            var radioCirculo = 100;

            //Circulo externo
            canvas.StrokeColor = Colors.Orange;
            canvas.StrokeSize = 5;
            canvas.DrawCircle(centroReloj, radioCirculo);
            canvas.DrawCircle(centroReloj, 5);

            // Las manecillas
            canvas.StrokeSize = 3;
            // Hora
            var horero = GetManecillaHora(tiempoActual, centroReloj, radioCirculo);
            canvas.DrawLine(centroReloj, horero);
            // Minuto
            var minutero = GetManecillaMinuto(tiempoActual, centroReloj, radioCirculo);
            canvas.DrawLine(centroReloj, minutero);
            // Segundo
            var segundero = GetManecillaSegundo(tiempoActual, centroReloj, radioCirculo);
            canvas.DrawLine(centroReloj, segundero);
        }

        internal static PointF GetManecillaSegundo(DateTime tiempoActual, PointF centroReloj, int radioCirculo)
        {
            int segundoActual = tiempoActual.Second;// 60 minutos
            var anguloGrad = segundoActual * 360 / 60;
            var anguloRad = anguloGrad * Math.PI / 180;
            PointF extremoManecilla = new PointF(
                centroReloj.X + (float)(radioCirculo * Math.Sin(anguloRad)),
                centroReloj.Y - (float)(radioCirculo * Math.Cos(anguloRad))
            );
            return extremoManecilla;
        }

        internal static PointF GetManecillaMinuto(DateTime tiempoActual, PointF centroReloj, int radioCirculo)
        {
            int minutoActual = tiempoActual.Minute;// 60 minutos
            var anguloGrad = minutoActual * 360 / 60;
            var anguloRad = anguloGrad * Math.PI / 180;
            var minuteroLongitud = radioCirculo * 0.9f;
            PointF extremoManecilla = new PointF(
                centroReloj.X + (float)(minuteroLongitud * Math.Sin(anguloRad)),
                centroReloj.Y - (float)(minuteroLongitud * Math.Cos(anguloRad))
            );
            return extremoManecilla;
        }

        internal static PointF GetManecillaHora(DateTime tiempoActual, PointF centroReloj, int radioCirculo)
        {
            int horaActual = tiempoActual.Hour;// 24 horas
            if(horaActual > 12) horaActual -= 12;
            var anguloGrad = horaActual * 360 / 12;
            var anguloRad = anguloGrad * Math.PI / 180;
            var horeroLongitud = radioCirculo * 0.6f;
            PointF extremoManecilla = new PointF(
                centroReloj.X + (float)(horeroLongitud * Math.Sin(anguloRad)),
                centroReloj.Y - (float)(horeroLongitud * Math.Cos(anguloRad))
            );
            return extremoManecilla;
        }
    }
}
