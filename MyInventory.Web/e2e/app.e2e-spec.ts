import { MyInventoryPage } from './app.po';

describe('my-inventory App', function() {
  let page: MyInventoryPage;

  beforeEach(() => {
    page = new MyInventoryPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
