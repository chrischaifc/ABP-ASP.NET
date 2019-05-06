import { MYABPTemplatePage } from './app.po';

describe('MYABP App', function() {
  let page: MYABPTemplatePage;

  beforeEach(() => {
    page = new MYABPTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
