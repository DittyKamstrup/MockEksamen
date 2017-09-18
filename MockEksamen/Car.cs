using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen
{

    public enum Color { Black, White, Gray, Red, Green, Blue }
    public class Car
    {
        /// <summary>
        /// INSTANCE FIELDS
        /// </summary>
        private int doors;
        private string model;
        private string registrationNo;
        private Color _color;
        private Owner owner;

        ///FULL PROPERTIES

        /// <summary>
        /// Doors er sat så der skal angives en værdi mellem 2 & 5 døre
        /// </summary>
        public int Doors
        {
            get { return doors; }
            set
            {
                if (value > 5 || value < 2)
                {
                    throw new ArgumentOutOfRangeException("Der kan være mellem 2 til 5 døre!");
                }
                doors = value;
            }
        }
        /// <summary>
        /// Model er sat så den skal navngives og kan derved ikke være null
        /// </summary>
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Equals(null))
                {
                    throw new NullReferenceException("Model skal angives!");
                }
                model = value;
            }
        }

        /// <summary>
        /// RegistrationNo er sat så den skal være på 7 tegn
        /// </summary>
        public string RegistrationNo
        {
            get { return registrationNo; }
            set
            {
                if (value.Length < 7 || value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("Registrerings nr skal være på 7 tegn!");
                }
                registrationNo = value;
            }
        }

        /// <summary>
        /// AUTO PROPERTIES
        /// </summary>
        public Owner CarOwner
        {
            get { return owner; }
            set { owner = value; }
        }

        /// <summary>
        /// Constructor til en Car objekt uden en Owner
        /// </summary>
        /// <param name="color"></param>
        /// <param name="doors"></param>
        /// <param name="model"></param>
        /// <param name="registrationNo"></param>
        public Car(Color color, int doors, string model, string registrationNo)
        {
            _color = color;
            Doors = doors;
            Model = model;
            RegistrationNo = registrationNo;

            //Da Color er en enum og derfor kun kan sættes som de fastsatte farver, så er denne switch ikke nødvendig
            switch (color)
            {
                case Color.Black: break;
                case Color.Blue: break;
                case Color.Gray: break;
                case Color.Green: break;
                case Color.Red: break;
                case Color.White: break;

                default: throw new ArgumentOutOfRangeException("Kan kun indskrive følgende farver: Black, Blue, Gray, Green, Red, White!");
            }
        }

        /// <summary>
        /// Overloading Constructor til en Car objekt med en Owner
        /// </summary>
        /// <param name="color"></param>
        /// <param name="doors"></param>
        /// <param name="model"></param>
        /// <param name="registrationNo"></param>
        /// <param name="owner"></param>
        public Car(Color color, int doors, string model, string registrationNo, Owner owner)
        {
            _color = color;
            Doors = doors;
            Model = model;
            RegistrationNo = registrationNo;
            CarOwner = owner;

            //Da Color er en enum og derfor kun kan sættes som de fastsatte farver, så er denne switch ikke nødvendig
            switch (color)
            {
                case Color.Black: break;
                case Color.Blue: break;
                case Color.Gray: break;
                case Color.Green: break;
                case Color.Red: break;
                case Color.White: break;

                default: throw new ArgumentOutOfRangeException("Kan kun indskrive følgende farver: Black, Blue, Gray, Green, Red, White!");
            }
        }
    }
}
