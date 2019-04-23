import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { DashboardComponent } from './dashboard/dashboard.component';
import { MerchandiseComponent } from './merchandise/merchandise.component';
import { VendorComponent } from './vendor/vendor.component';
import { VendorTypeComponent } from './vendortype/vendortype.component';

import { AssignmentTableComponent } from './assignment-table/assignment-table.component';

@NgModule({
    imports: [
        RouterModule.forChild([
            {
                path: '',
                children: [
                    { path: 'dashboard', component: DashboardComponent, data: { permission: 'Pages.Tenant.Dashboard' } },
                    { path: 'merchandise', component: MerchandiseComponent, data: { permission: 'Pages.Administration.Merchandise' } },
                    { path: 'vendor', component: VendorComponent, data: { permission: 'Pages.Administration.Vendor' } },
                    { path: 'vendortype', component: VendorTypeComponent, data: { permission: 'Pages.Administration.VendorType' } },
                    { path: 'assignment-table', component: AssignmentTableComponent }
                ]
            }
        ])
    ],
    exports: [
        RouterModule
    ]
})
export class MainRoutingModule { }
