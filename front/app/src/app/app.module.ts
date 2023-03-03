import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SoundDetailComponent } from './sample/sound-detail/sound-detail.component';
import { SoundGridComponent } from './sample/sound-grid/sound-grid.component';
import { SoundListComponent } from './sample/sound-list/sound-list.component';
import { SoundItemComponent } from './sample/sound-grid/sound-item/sound-item.component';
import { SearchBarComponent } from './search-bar/search-bar.component';
import { SearchPipe } from './pipes/search.pipe';
import { RouterTestingModule } from "@angular/router/testing";
import { SoundService } from './sample/services/sound.service';
import { HttpClientModule } from '@angular/common/http';
import { NavBarComponent } from './sample/nav-bar/nav-bar.component';
// import { MdbAccordionModule } from 'mdb-angular-ui-kit/accordion';
// import { MdbCarouselModule } from 'mdb-angular-ui-kit/carousel';
// import { MdbCheckboxModule } from 'mdb-angular-ui-kit/checkbox';
import { MdbCollapseModule } from 'mdb-angular-ui-kit/collapse';
// import { MdbDropdownModule } from 'mdb-angular-ui-kit/dropdown';
// import { MdbFormsModule } from 'mdb-angular-ui-kit/forms';
// import { MdbModalModule } from 'mdb-angular-ui-kit/modal';
// import { MdbPopoverModule } from 'mdb-angular-ui-kit/popover';
// import { MdbRadioModule } from 'mdb-angular-ui-kit/radio';
// import { MdbRangeModule } from 'mdb-angular-ui-kit/range';
// import { MdbRippleModule } from 'mdb-angular-ui-kit/ripple';
// import { MdbScrollspyModule } from 'mdb-angular-ui-kit/scrollspy';
// import { MdbTabsModule } from 'mdb-angular-ui-kit/tabs';
// import { MdbTooltipModule } from 'mdb-angular-ui-kit/tooltip';
// import { MdbValidationModule } from 'mdb-angular-ui-kit/validation';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MDBBootstrapModule } from 'angular-bootstrap-md';


@NgModule({
  declarations: [
    AppComponent,
    SoundDetailComponent,
    SoundGridComponent,
    SoundListComponent,
    SoundItemComponent,
    SearchBarComponent,
    SearchPipe,
    NavBarComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterTestingModule,
    MDBBootstrapModule,
    // MdbAccordionModule,
    // MdbCarouselModule,
    // MdbCheckboxModule,
    MdbCollapseModule,
    // MdbDropdownModule,
    // MdbFormsModule,
    // MdbModalModule,
    // MdbPopoverModule,
    // MdbRadioModule,
    // MdbRangeModule,
    // MdbRippleModule,
    // MdbScrollspyModule,
    // MdbTabsModule,
    // MdbTooltipModule,
    // MdbValidationModule,
    BrowserAnimationsModule,
  ],
  providers: [SoundService],
  bootstrap: [AppComponent]
})
export class AppModule { }
