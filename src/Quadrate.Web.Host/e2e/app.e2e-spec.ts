import { QuadrateTemplatePage } from './app.po';

describe('Quadrate App', function() {
  let page: QuadrateTemplatePage;

  beforeEach(() => {
    page = new QuadrateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
