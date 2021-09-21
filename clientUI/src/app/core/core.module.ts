import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { ErrorTestComponent } from './error-test/error-test.component';
import { ToastrModule } from 'ngx-toastr';
import { RouterModule } from '@angular/router';
import { IconsProviderModule } from '../icons-provider.module';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import { en_US, NZ_I18N } from 'ng-zorro-antd/i18n';



@NgModule({
  declarations: [NavBarComponent, ErrorTestComponent],
  imports: [
    CommonModule,
    RouterModule.forRoot([{path: 'error-test', component: ErrorTestComponent}]),
    ToastrModule.forRoot(),
    IconsProviderModule,
    NzLayoutModule,
    NzMenuModule,

  ],
  providers: [{ provide: NZ_I18N, useValue: en_US }],
  exports: [NavBarComponent]
})
export class CoreModule { }
