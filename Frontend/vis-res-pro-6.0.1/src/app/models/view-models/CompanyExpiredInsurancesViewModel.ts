
export class CompanyExpiredInsurancesViewModel {
    insuranceType: string;
    numberExpired: number;
    hide: boolean;

    constructor(InsuranceType: string, NumberExpired: number) {
      this.insuranceType = InsuranceType;
      this.numberExpired = NumberExpired;
    }

    // toggle() {
    //   this.hide = !this.hide;
    // }
}
