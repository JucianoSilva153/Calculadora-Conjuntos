using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_TLP___Calculo_de_Conjuntos
{
    class frm_conjunto: operacao_conjunto
    {

        public HashSet<string> ConjuntoA;
        public HashSet<string> ConjuntoB;

        //Constructor
        public frm_conjunto(HashSet<string> vConjuntoA, HashSet<string> vconjuntoB): base(vConjuntoA, vconjuntoB)
        {

            this.ConjuntoA = vConjuntoA;
            this.ConjuntoB = vconjuntoB;
        }

        public override HashSet<string> uniao()
        {
            HashSet<string> uniaoAB = new HashSet<string>(this.ConjuntoA);
            uniaoAB.UnionWith(this.ConjuntoB);

            return uniaoAB;
        }

        public override HashSet<string> interccao()
        {
            HashSet<string> interceccao = new HashSet<string>(this.ConjuntoA);
            interceccao.IntersectWith(this.ConjuntoB);

            return interceccao;
        }

        public override HashSet<string> simetria()
        {

            HashSet<string> simetriaAB = new HashSet<string>(this.ConjuntoA);
            simetriaAB.SymmetricExceptWith(this.ConjuntoB);

            return simetriaAB;

        }

       public override HashSet<string> diferencaAB() {

            HashSet<string> diferenciaAB = new HashSet<string>(this.ConjuntoA);
            diferenciaAB.ExceptWith(this.ConjuntoB);

            return diferenciaAB;
        }

        public override HashSet<string> diferencaBA()
        {
            HashSet<string> diferenciaAB = new HashSet<string>(this.ConjuntoB);
            diferenciaAB.ExceptWith(this.ConjuntoA);

            return diferenciaAB;
        }

    }
}
