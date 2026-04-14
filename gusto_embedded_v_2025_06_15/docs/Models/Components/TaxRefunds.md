# TaxRefunds

Describes the taxes which are refundable to the company for this suspension. These may be refunded, or paid
by Gusto, depending on the value in `reconcile_tax_method`.



## Fields

| Field                     | Type                      | Required                  | Description               |
| ------------------------- | ------------------------- | ------------------------- | ------------------------- |
| `Amount`                  | *string*                  | :heavy_minus_sign:        | Dollar amount.            |
| `Description`             | *string*                  | :heavy_minus_sign:        | What kind of tax this is. |