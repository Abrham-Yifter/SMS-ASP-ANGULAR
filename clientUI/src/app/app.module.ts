import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { CoreModule } from './core/core.module';
import {FeatureModule} from './feature/feature.module';


import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { registerLocaleData } from '@angular/common';
import en from '@angular/common/locales/en';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { IconsProviderModule } from './icons-provider.module';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import { en_US, NZ_I18N } from 'ng-zorro-antd/i18n';
import { NzFormModule } from 'ng-zorro-antd/form';
import { NzTagModule } from 'ng-zorro-antd/tag';

import { AccountModule } from './account/account.module';
import { SchemComponent } from './schem/schem.component';


registerLocaleData(en);

@NgModule({
  declarations: [
    AppComponent,
    SchemComponent,
  ],
  imports: [
    BrowserModule,
    CommonModule,
    CoreModule,
    BrowserAnimationsModule,
    HttpClientModule,
    CoreModule,
    FeatureModule,
    AccountModule,
    NgbModule,
    FormsModule,
    AppRoutingModule,
    IconsProviderModule,
    
    NzLayoutModule,
    NzMenuModule,
    NzFormModule,
    NzTagModule

  ],
  providers: [{ provide: NZ_I18N, useValue: en_US }],
  bootstrap: [AppComponent]
})
export class AppModule { }
