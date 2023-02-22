using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigenschaftsmethode
{
    class Fahrzeug
    {

        /// Nach wie vor gibt es die geschützte Eigenschaft geschwindigkeit
        private int geschwindigkeit;                    

        /// Zu dieser Eigenschaft wird die Eigenschaftsmethode (engl. property) Geschwindigkeit hinzugefügt. Der Name einer Eigenschaftsmethode sollte gemäß Konvention so lauten
        /// wie der Name der zugehörigen Eigenschaft, allerdings mit einem Großbuchstaben zu Beginn.
        /// Eigenschaftsmethoden präsentieren sich wie eine Mischform aus Eigenschaft und Methode. Sie bestehen aus sogenannten Accessoren, einem get-Accessor und einem set-Accessor.
        /// Der get-Accessor ist verantwortlich für das Lesen der Eigenschaft geschwindigkeit, der set-Accessor ist verantwortlich für das Schreiben in die Eigenschaft geschwindigkeit.
        /// 
        ///Im vorliegenden Programm wird die Eigenschaftsmethode mit public öffentlich gemacht. Der set-Accessor wir dagegen mit private gekapselt. Somit kann die Eigenschaft geschwindigkeit
        ///außerhalb der Klasse gelesen, aber nicht verändert werden. Sie können Sie nur über die öffentliche Methode Beschleunigen() verändern.
        ///Ein Accessor muss mindestens so restrektiv sein wie die die Eigenschaftsmethode. Somit ist die Kombination gekapselte Eigenschaftsmethode und öffentlicher Accessor nicht möglich.
        ///
        ///Dem set-Accessor steht über das Schlüsselwort value der gelieferte Wert wie ein Parameter zur Verfügung.
        ///Im set-Accessor wird durch eine Verzeigung dafür gesorgt, dass der Wert der Eigenschaft geschwindigkeit nicht kleiner als 0 und nicht größer als 100 werden darf (es wird also eine
        ///Geschwindigkeitsbegrenzung festgelegt). Eine solche Kontrolle ist einer der Einsatzzwecke einer Eigenschaftsmethode.
        public int Geschwindigkeit                      
        {
            get
            {
                return geschwindigkeit;
            }
            private set
            {
                if (value > 100)
                {
                    geschwindigkeit = 100;
                }
                else if (value < 0)
                {
                    geschwindigkeit = 0;
                }
                else
                {
                    geschwindigkeit = value;
                }
            }
        }

        /// In der Methode Beschleunigen() wird der gelieferte Wert zu der Eigenschaftsmethode hinzuaddiert. Auf diese Weise wird dafür gesorgt, dass sich auch bei Aufruf der Methode Beschleunigen()
        /// der Wert der Eigenschaft geschwindigkeit nur inerhalb der erlaubten Grenzen bewegt.
        public void Beschleunigen(int wert)
        {
            Geschwindigkeit += wert;
        }
    }
}
