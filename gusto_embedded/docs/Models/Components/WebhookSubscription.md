# WebhookSubscription

The representation of webhook subscription.


## Fields

| Field                                                                                     | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `Uuid`                                                                                    | *string*                                                                                  | :heavy_check_mark:                                                                        | The UUID of the webhook subscription.                                                     |
| `Url`                                                                                     | *string*                                                                                  | :heavy_minus_sign:                                                                        | The webhook subscriber URL. Updates will be POSTed to this URL.                           |
| `Status`                                                                                  | [WebhookSubscriptionStatus](../../Models/Components/WebhookSubscriptionStatus.md)         | :heavy_minus_sign:                                                                        | The status of the webhook subscription.                                                   |
| `SubscriptionTypes`                                                                       | List<[Models.Components.SubscriptionTypes](../../Models/Components/SubscriptionTypes.md)> | :heavy_minus_sign:                                                                        | Receive updates for these types.                                                          |