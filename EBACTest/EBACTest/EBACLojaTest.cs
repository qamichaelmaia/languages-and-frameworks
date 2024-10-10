///Teste de implementação com Playwright e .Net

using Microsoft.Playwright;
/// Biblioteca Playwright usada para automação de navegadores.

namespace EBACTest
{
    [TestClass] // Indica que esta classe contém métodos de teste.
    public class EBACLojaTest
    {
        [TestMethod] // Define que este método é um teste que será executado.
        public async Task shouldAccessHome()
        {
            const string lojaUrl = "http://lojaebac.ebaconline.art.br";
            /// Constante que armazena a URL da loja EBAC.

            using var playwright = await Playwright.CreateAsync();
            /// Inicializa o objeto Playwright, que fornece acesso às funcionalidades de automação de navegadores.

            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions { Channel = "chrome", Headless = false });
            /// Inicia o navegador Chromium (neste caso, a versão Chrome) em modo não headless (abre o navegador visualmente).

            var page = await browser.NewPageAsync();
            /// Cria uma nova página (aba) no navegador.

            await page.GotoAsync(lojaUrl);
            /// Navega para a URL definida ("http://lojaebac.ebaconline.art.br").

            Assert.AreEqual(await page.TitleAsync(), "EBAC – Shop – Página de teste");
            /// Verifica se o título da página corresponde ao esperado.
            /// Pode ser necessário alterar o título para "Home" ou outro valor correto, dependendo da página real.
        }
    }
}
