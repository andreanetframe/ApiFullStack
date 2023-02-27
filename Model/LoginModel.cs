using fullstack.Data;

namespace fullstack.Model
{
    public partial class LoginModel
    {
        public UserData u { get; set; }

        public Boolean IsSuccess(string user, string password)
        {
            // controllo credenziali
            if (user.Equals("andrea") && password.Equals("pwd123")) {
                // login corretto, ritorno utente
                u = new UserData();
                u.id = 10;
                u.name = "Andrea";
                u.token = Guid.NewGuid().ToString();
                u.AddMenuItem(1, "Clienti");
                u.AddMenuItem(2, "Fornitori");
                u.AddMenuItem(3, "Anagrafica articoli");
                u.AddMenuItem(4, "Magazzino");
                u.AddMenuItem(5, "Fatturazione");

                return true;
            }

            // login errato
            return false;
        }

        public UserData GetUser(int id)
        {
            if (id == 1)
            {
                // login corretto, ritorno utente
                u = new UserData();
                u.id = id;
                u.name = "Andrea";
                u.token = Guid.NewGuid().ToString();
                u.AddMenuItem(2, "Fornitori");
                u.AddMenuItem(4, "Magazzino");
                
                return u;
            }

            if (id == 2)
            {
                // login corretto, ritorno utente
                u = new UserData();
                u.id = id;
                u.name = "Davide";
                u.token = Guid.NewGuid().ToString();
                u.AddMenuItem(1, "Clienti");
                u.AddMenuItem(3, "Anagrafica articoli");
                u.AddMenuItem(5, "Fatturazione");

                return u;
            }

            // non trovato
            return null;
        }

    }
}
