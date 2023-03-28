using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UT2_E3
{
    internal class Calculadora
    {
        private float _cache;
        private float _visor;
        private float _memoria;
        private OperacionEnum _operacion;
        public OperacionEnum Operacion{
            get
            {
                return _operacion;
            }
            set
            {
                if (_operacion==0)
                {
                    _cache = _visor;
                }
                else
                {
                    Calcular();
                    _cache = _visor;
                }
                _operacion = value;
            }
        }
        public float Visor {
            get 
            { 
                return _visor; 
            } 
            set 
            { 
                _visor = value; 
            } 
        }
        public void Calcular()
        {
            switch (Operacion)
            {
                case OperacionEnum.SinOperacion:
                    return;
                case OperacionEnum.Suma:
                    _visor = _cache + _visor ;
                    break;
                case OperacionEnum.Resta:
                    _visor=_cache - _visor;
                    break;
                case OperacionEnum.Multiplicacion:
                    _visor = _cache * _visor;
                    break;
                case OperacionEnum.Division:
                    _visor = _cache / _visor;
                    break;
            }
            _operacion = OperacionEnum.SinOperacion;
        }
    
        public void Borrar()
        {
            _cache = 0;
            _operacion = OperacionEnum.SinOperacion;
        }

    }

    

}
