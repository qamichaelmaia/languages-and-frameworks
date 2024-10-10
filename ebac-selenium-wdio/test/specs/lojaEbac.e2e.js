const homePage = require ("../pageobjects/home.page");

describe('Loja EBAC', () => {
    it('should access home page', async () => {
        await homePage.open(); // Abre a página inicial
        expect(await homePage.title).toBe("EBAC – Shop – Página de teste"); // Verifica se o título está correto
    });
});
