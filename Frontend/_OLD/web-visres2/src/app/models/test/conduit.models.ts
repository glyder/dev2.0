export interface Profile {
  username: string;
  bio: string;
  image: string;
  following: boolean;
}

// =======================================

export interface ArticleListConfig {
  type: string;

  filters: {
    tag?: string,
    author?: string,
    favorited?: string,
    limit?: number,
    offset?: number
  };
}

export interface Article {
  slug: string;
  title: string;
  description: string;
  body: string;
  tagList: string[];
  createdAt: string;
  updatedAt: string;
  favorited: boolean;
  favoritesCount: number;

  author: Profile;
}

export interface Comment {
  id: number;
  body: string;
  createdAt: string;

  author: Profile;
}

export interface Errors {
  errors: {[key: string]: string};
}


export interface User {
  email: string;
  token: string;
  username: string;
  bio: string;
  image: string;
}
