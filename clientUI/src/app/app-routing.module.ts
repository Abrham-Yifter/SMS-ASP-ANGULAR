import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  { path: 'account', loadChildren: ()=> import('./account/account.module')
  .then((res) => res.AccountModule)
  },
  { path: 'test', loadChildren: ()=> import('./feature/feature.module')
  .then((res) => res.FeatureModule)
  },
  //{ path: 'welcome', loadChildren: () => import('./pages/welcome/welcome.module').then(m => m.WelcomeModule) }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
