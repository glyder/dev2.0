import { browser, by, element } from 'protractor';

export class AppPage {
  navigateTo() {
    return browser.get('/');
  }

  getHomeTitle() {
    return element(by.css('app-root h1')).getText();
  }

  // getParagraphText() {
  //   return element(by.css('app-root h1')).getText();
  // }



}
