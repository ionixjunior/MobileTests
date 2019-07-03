//
//  ViewController.m
//  AppObjectiveC
//
//  Created by Ione Souza Junior on 02/07/19.
//  Copyright © 2019 Ione Souza Junior. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do any additional setup after loading the view.
}


- (IBAction)onLoadDataClick:(id)sender {
    NSString *targetUrl = @"https://mobiletests.getsandbox.com/ping";
    NSMutableURLRequest *request = [[NSMutableURLRequest alloc] init];
    [request setHTTPMethod:@"GET"];
    [request setURL:[NSURL URLWithString:targetUrl]];
    [[[NSURLSession sharedSession] dataTaskWithRequest:request completionHandler:
      ^(NSData * _Nullable data,
        NSURLResponse * _Nullable response,
        NSError * _Nullable error) {
          NSString *result = [[NSString alloc] initWithData:data encoding:NSUTF8StringEncoding];
          dispatch_async(dispatch_get_main_queue(), ^{
              self->_lblData.text = result;
          });
      }] resume];
}
@end
