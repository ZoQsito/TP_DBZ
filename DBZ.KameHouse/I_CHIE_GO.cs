using DBZ.Dojo.Vestiaires;

namespace DBZ.KameHouse
{
    public class I_CHIE_GO : IGuerrier
    {
        public string Nom
        {
            get
            {
                return "I_CHIE_GO";
            }
        }

        private bool _jeSuisCharge;

        public ActionDeCombat ChoixProchaineAction(ActionDeCombat dernierActionAdversaire)
        {
            if (dernierActionAdversaire == ActionDeCombat.KameHameHa)
            {
                if (_jeSuisCharge) // Si le KameHameHa est déjà chargé, on l'utilise
                {
                    _jeSuisCharge = false;
                    return ActionDeCombat.KameHameHa;
                }
                else // Sinon, on le charge
                {
                    _jeSuisCharge = true;
                    return ActionDeCombat.ChargeKameHameHa;
                }
            }
            else
            {
                if (dernierActionAdversaire == ActionDeCombat.Parade)
                {
                    if (_jeSuisCharge)
                    {
                        _jeSuisCharge = false;
                        return ActionDeCombat.KameHameHa;
                    }
                    else
                    {
                        _jeSuisCharge = true;
                        return ActionDeCombat.ChargeKameHameHa;
                    }
                }
                else
                {
                    if (dernierActionAdversaire == ActionDeCombat.ChargeKameHameHa)
                    {
                        return ActionDeCombat.Parade;
                    }
                    else
                    {
                        _jeSuisCharge = true;
                        return ActionDeCombat.ChargeKameHameHa;
                    }
                }
            }


        }
    }
}