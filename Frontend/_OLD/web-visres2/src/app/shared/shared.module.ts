import { NgModule } from '@angular/core';
import { SharedRoutingModule } from './shared-routing.module';
import { RouterModule } from '@angular/router';

// Angular
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

// Components - Conduit - to remove
import { ArticleListComponent, ArticleMetaComponent, ArticlePreviewComponent,
         FavoriteButtonComponent, FollowButtonComponent, PopularTagsComponent,
         ListErrorsComponent, ShowAuthedDirective} from '@vrs/shared/components';

// Components - MDB
import { TesterHtmlComponent } from '@vrs/shared/components';

// UI
import { ButtonComponent } from '@vrs/shared/ui';


@NgModule({
  imports: [
    CommonModule, RouterModule, SharedRoutingModule,
    FormsModule, ReactiveFormsModule, HttpClientModule,
  ],

  exports: [
    CommonModule, RouterModule,
    FormsModule, ReactiveFormsModule, HttpClientModule,

    // Component - Conduit
    ArticleListComponent, ArticleMetaComponent, ArticlePreviewComponent,
    FavoriteButtonComponent, FollowButtonComponent, PopularTagsComponent,
    ListErrorsComponent, ShowAuthedDirective,

    // Components - VRS
    TesterHtmlComponent,                              // MDB

    // UI
    ButtonComponent,
  ],

  declarations: [

    // Component - Conduit
    ArticleListComponent, ArticleMetaComponent, ArticlePreviewComponent,
    FavoriteButtonComponent, FollowButtonComponent,
    ListErrorsComponent, ShowAuthedDirective,

    // Components - VRS
    TesterHtmlComponent,                              // MDB
    PopularTagsComponent,

    // UI
    ButtonComponent,
  ]

})
export class SharedModule { }
