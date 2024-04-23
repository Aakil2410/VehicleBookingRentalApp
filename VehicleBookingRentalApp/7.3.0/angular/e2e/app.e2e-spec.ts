import { VehicleBookingRentalAppTemplatePage } from './app.po';

describe('VehicleBookingRentalApp App', function() {
  let page: VehicleBookingRentalAppTemplatePage;

  beforeEach(() => {
    page = new VehicleBookingRentalAppTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
