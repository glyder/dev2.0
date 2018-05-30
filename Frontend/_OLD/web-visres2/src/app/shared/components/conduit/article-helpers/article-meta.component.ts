import { Component, Input } from '@angular/core';

import { Article } from '@vrs/models/test';

@Component({
  selector: 'app-article-meta',
  templateUrl: './article-meta.component.html'
})
export class ArticleMetaComponent {
  @Input() article: Article;
}
