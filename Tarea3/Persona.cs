namespace Tarea3
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string DNI;

        public Persona()
        {
        }

        /*************************************************/
        /**  Metodo SET y GET para el atributo nombre   **/
        /*************************************************/

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /*************************************************/
        /**  Metodo SET y GET para el atributo Edad     **/
        /*************************************************/

        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }


        /*************************************************/
        /**  Metodo SET y GET para el atributo DNI      **/
        /*************************************************/
        public string Dni
        {
            get { return this.DNI; }
            set { this.DNI = value; }
        }
    }


    //Clase llamada punto, creada para representar un punto en el plano

    public class Punto
    {
        private float x;
        private float y;

        public Punto()
        {
        }


        /*************************************************/
        /**  Metodo SET y GET para el atributo x        **/
        /*************************************************/

        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }


        /*************************************************/
        /**  Metodo SET y GET para el atributo y        **/
        /*************************************************/

        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

    }


    //Clase llamada circulo, contiene un método que permite calcular el area del ciruclo

    public class Circulo
    {
        float x;
        float y;
        float radio;

        public Circulo()
        {
        }

        /*************************************************/
        /**  Metodo SET y GET para el atributo x        **/
        /*************************************************/
        public float X
        {
            get { return this.x; }
            set { this.x = value; }
        }


        /*************************************************/
        /**  Metodo SET y GET para el atributo y        **/
        /*************************************************/
        public float Y
        {
            get { return this.y; }
            set { this.y = value; }
        }


        /*************************************************/
        /**  Metodo SET y GET para el atributo radio    **/
        /*************************************************/
        public float Radio
        {
            get { return this.radio; }
            set { this.radio = value; }
        }


        /*************************************************/
        /**  Metodo calcular el area del circulo        **/
        /*************************************************/


        public double areaCirculo(float rd)
        {
            //Area del circulo = PI * radio al cuadrado
            const double pi = 3.1416;
            double resultado = 0;

            Circulo nue = new Circulo();

            resultado = pi * (rd * rd);
            return resultado;
        }

    }

}