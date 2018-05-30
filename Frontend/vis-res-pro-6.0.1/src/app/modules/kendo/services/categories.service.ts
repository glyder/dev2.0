import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; // HttpClientModule
import { BehaviorSubject } from 'rxjs/BehaviorSubject';
import { map } from 'rxjs/operators/map';

@Injectable({
  providedIn: 'root'
})
export class LobsService extends BehaviorSubject<any> {
    private BASE_URL = 'http://localhost:65464/api/';
    private tableName = 'maintenance/Lobs/Lobs-Listbox';

    constructor(private http: HttpClient) {
        super(null);
    }

    public query(): void {
        this.fetch(this.tableName)
            .subscribe((x: any) => super.next(x));
    }

    private fetch(tableName: string): any {
        const queryStr = `$skip=0&$count=true`;
        return this.http
                   .get(`${this.BASE_URL}${tableName}?${queryStr}`)
                   .pipe(map((response: any) => response));
    }
}
