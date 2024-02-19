namespace ConvertidorMayusculasMVC
{
    public class Controlador
    {
        private ConvertidorMayusculas vista;

        public Controlador(ConvertidorMayusculas vista)
        {
            this.vista = vista;
        }

        public void ConvertirAMayusculas()
        {
            TextoModelo modelo = new TextoModelo(vista.ObtenerTexto());
            modelo.Texto = modelo.Texto.ToUpper();
            vista.EstablecerTexto(modelo.Texto);
        }
    }
}
