import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.AfterTest;
import org.testng.annotations.BeforeTest;
import org.testng.annotations.Test;

public class LojaEbacTest {

    static ChromeDriver driver;

    @BeforeTest
    public static void setUp(){ //Configura o ChromeDriver antes do teste.
        System.setProperty("webdriver.chrome.driver", "C:\\chromedriver-win64\\chromedriver.exe");
        driver = new ChromeDriver();
    }

    @Test
    public void shouldAccessHomePage(){ //Realiza o teste acessando a página e validando o título.
        driver.get("http://lojaebac.ebaconline.art.br");
        Assert.assertEquals(driver.getTitle(), "EBAC – Shop – Página de teste");

    }
    @AfterTest
    public static void tearDown(){ //Fecha o navegador ao final do teste.
        driver.close();
    }
}
