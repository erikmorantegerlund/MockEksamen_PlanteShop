using System;

namespace PlanteCenter
{
    public class Planter
    {
        private int _id;
        private string __type;
        private string _navn;
        private int _pris;
        private int _maksHøjde;

        public Planter(int id, string type, string navn, int pris, int maksHøjde)
        {
            _id = id;
            __type = type;
            _navn = navn;
            _pris = pris;
            _maksHøjde = maksHøjde; 
        }

        public Planter()
        {
                
        }

        public int Id
        {
            get { return _id; }
            set { value = _id; }
        }

        public string Type
        {
            get { return __type; }
            set { value = __type; }
        }

        public string Navn
        {
            get { return _navn; }
            set { value = _navn; }
        }

        public int Pris
        {
            get { return _pris; }
            set { value = Pris; }
        }

        public int MaksHøjde
        {
            get { return _maksHøjde; }
            set { value = _maksHøjde; }
        }

        public override string ToString()
        {
            return $"{nameof(_id)}: {_id}, {nameof(__type)}: {__type}, {nameof(_navn)}: {_navn}, {nameof(_pris)}: {_pris}, {nameof(_maksHøjde)}: {_maksHøjde}";
        }
    }
}
