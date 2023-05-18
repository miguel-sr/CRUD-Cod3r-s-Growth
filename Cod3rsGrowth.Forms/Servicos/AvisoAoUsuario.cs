using System.Windows.Forms;

namespace Cod3rsGrowth.Servicos
{
    public class AvisoAoUsuario
    {
        public static void ModalAviso(string texto)
        {
            MessageBox.Show(texto, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DialogResult ModalConfirmarAcao(string texto)
        {
            return MessageBox.Show(texto, "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }
    }
}
