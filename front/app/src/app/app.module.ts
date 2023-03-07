import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { SoundDetailComponent } from './sample/sound-detail/sound-detail.component';
import { SoundGridComponent } from './sample/sound-grid/sound-grid.component';
import { SoundItemComponent } from './sample/sound-grid/sound-item/sound-item.component';
import { SearchBarComponent } from './search-bar/search-bar.component';
import { SearchPipe } from './pipes/search.pipe';
import { SoundService } from './sample/services/sound.service';
import { HttpClientModule } from '@angular/common/http';
import { NavBarComponent } from './sample/nav-bar/nav-bar.component';
import { MdbCollapseModule } from 'mdb-angular-ui-kit/collapse';
// import { MdbAccordionModule } from 'mdb-angular-ui-kit/accordion';
// import { MdbCarouselModule } from 'mdb-angular-ui-kit/carousel';
// import { MdbCheckboxModule } from 'mdb-angular-ui-kit/checkbox';
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
import { AppRoutingModule } from './app-routing.module';
import { AudioPlayerComponent } from './audio-player/audio-player.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { SoundCreateComponent } from './sample/sound-create/sound-create.component'; 
import { ReactiveFormsModule } from '@angular/forms';
import { SoundValidator } from './sample/validators/sound.validator';

@NgModule({
  declarations: [
    AppComponent,
    SoundDetailComponent,
    SoundGridComponent,
    SoundItemComponent,
    SearchBarComponent,
    SearchPipe,
    NavBarComponent,
    AudioPlayerComponent,
    SoundCreateComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    MDBBootstrapModule,
    NgxPaginationModule,
    ReactiveFormsModule,
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
  providers: [SoundService, SoundValidator],
  entryComponents: [SoundCreateComponent],
  bootstrap: [AppComponent]
})
export class AppModule { }
