import { MyInventory.WebPage } from './app.po';

describe('my-inventory.web App', () => {
  let page: MyInventory.WebPage;

  beforeEach(() => {
    page = new MyInventory.WebPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
