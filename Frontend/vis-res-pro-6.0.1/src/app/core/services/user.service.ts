import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { User } from '@vrs/models';

@Injectable()
export class UserService {
    constructor(private http: HttpClient) { }

    getAll() {
        return this.http.get<User[]>('http://localhost:65464/api/users');
    }

    getById(id: number) {
        return this.http.get('http://localhost:65464/api/users/' + id);
    }

    create(user: User) {
        return this.http.post('http://localhost:65464/api/users', user);
    }

    update(user: User) {
        return this.http.put('http://localhost:65464/api/users/' + user.id, user);
    }

    delete(id: number) {
        return this.http.delete('http://localhost:65464/api/users/' + id);
    }
}

// export class User {
//     id: number;
//     username: string;
//     password: string;
//     firstName: string;
//     lastName: string;
// }
