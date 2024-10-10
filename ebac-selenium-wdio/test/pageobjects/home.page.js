const Page = require('./page');

class HomePage extends Page {
    get title(){
        return browser.getTitle()
    }
    open(){
        return super.open("http://lojaebac.ebaconline.art.br/")
    }
}

module.exports = new HomePage();