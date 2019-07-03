//
//  ViewController.h
//  AppObjectiveC
//
//  Created by Ione Souza Junior on 02/07/19.
//  Copyright © 2019 Ione Souza Junior. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface ViewController : UIViewController

- (IBAction)onLoadDataClick:(id)sender;
@property (weak, nonatomic) IBOutlet UIButton *btnLoadData;
@property (weak, nonatomic) IBOutlet UILabel *lblData;

@end

