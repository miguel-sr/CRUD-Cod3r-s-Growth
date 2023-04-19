using System.Windows.Forms;

namespace Cod3rsGrowth.Servicos
{
    public class AvisoAoUsuario
    {
        public static void ModalAviso(string text)
        {
            MessageBox.Show(text, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
