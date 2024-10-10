///Teste de implementa��o com Playwright e .Net

using Microsoft.Playwright;
/// Biblioteca Playwright usada para automa��o de navegadores.

namespace EBACTest
{
    [TestClass] // Indica que esta classe cont�m m�todos de teste.
    public class EBACLojaTest
    {
        [TestMethod] // Define que este m�todo � um teste que ser� executado.
        public async Task shouldAccessHome()
        {
            const string lojaUrl = "http://lojaebac.ebaconline.art.br";
            /// Constante que armazena a URL da loja EBAC.

            using var playwright = await Playwright.CreateAsync();
            /// Inicializa o objeto Playwright, que fornece acesso �s funcionalidades de automa��o de navegadores.

            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions { Channel = "chrome", Headless = false });
            /// Inicia o navegador Chromium (neste caso, a vers�o Chrome) em modo n�o headless (abre o navegador visualmente).

            var page = await browser.NewPageAsync();
            /// Cria uma nova p�gina (aba) no navegador.

            await page.GotoAsync(lojaUrl);
            /// Navega para a URL definida ("http://lojaebac.ebaconline.art.br").

            Assert.AreEqual(await page.TitleAsync(), "EBAC � Shop � P�gina de teste");
            /// Verifica se o t�tulo da p�gina corresponde ao esperado.
            /// Pode ser necess�rio alterar o t�tulo para "Home" ou outro valor correto, dependendo da p�gina real.
        }
    }
}
