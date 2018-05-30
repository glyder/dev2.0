
export class DropDownList {

  public value?: number | null;
  public text: string;
    // selected: number;

  constructor(value: number, text: string) { // , selected: number) {
    this.value = value;
    this.text = text;
    // this.selected = selected;
  }
}
