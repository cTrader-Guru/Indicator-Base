/*  CTRADER GURU --> Indicator Template 1.0.6

    Homepage    : https://ctrader.guru/
    Telegram    : https://t.me/ctraderguru
    Twitter     : https://twitter.com/cTraderGURU/
    Facebook    : https://www.facebook.com/ctrader.guru/
    YouTube     : https://www.youtube.com/channel/UCKkgbw09Fifj65W5t5lHeCQ
    GitHub      : https://github.com/ctrader-guru

*/

using cAlgo.API;

namespace cAlgo
{

    [Indicator(IsOverlay = false, TimeZone = TimeZones.UTC, AccessRights = AccessRights.FullAccess)]
    public class INDICATORBASE : Indicator
    {

        #region Enums

        // --> Eventuali enumeratori li mettiamo qui

        #endregion

        #region Identity

        /// <summary>
        /// Nome del prodotto, identificativo, da modificare con il nome della propria creazione
        /// </summary>
        public const string NAME = "Indicator Base";

        /// <summary>
        /// La versione del prodotto, progressivo, utilie per controllare gli aggiornamenti se viene reso disponibile sul sito ctrader.guru
        /// </summary>
        public const string VERSION = "1.0.6";

        #endregion

        #region Params

        /// <summary>
        /// Identità del prodotto nel contesto di ctrader.guru
        /// </summary>
        [Parameter(NAME + " " + VERSION, Group = "Identity", DefaultValue = "https://ctrader.guru/product/indicator-base/")]
        public string ProductInfo { get; set; }

        /// <summary>
        /// L'output primario, può essere modificato a seconda delle esigenze
        /// </summary>
        [Output("Main")]
        public IndicatorDataSeries Result { get; set; }

        #endregion

        #region Property

        // --> Qui inseriremo variabili e costanti del progetto

        #endregion

        #region Indicator Events

        /// <summary>
        /// Viene generato all'avvio dell'indicatore, si inizializza l'indicatore
        /// </summary>
        protected override void Initialize()
        {

            // --> Stampo nei log la versione corrente
            Print("{0} : {1}", NAME, VERSION);

        }

        /// <summary>
        /// Generato ad ogni tick, vengono effettuati i calcoli dell'indicatore
        /// </summary>
        /// <param name="index">L'indice della candela in elaborazione</param>
        public override void Calculate(int index)
        {

            // -->>> Qui calchiamo e assegnamo il valore del nostro indicatore nel buffer
            // --> Result[index] = ...

        }

        #endregion

        #region Private Methods

        // --> Seguiamo la signature con underscore "_mioMetodo()"

        #endregion

    }

}

