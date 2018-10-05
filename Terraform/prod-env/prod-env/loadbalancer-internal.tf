module "loadbalancer-internal" {
  source                    = "../../modules/loadBalancer-module"
  balancer-name             = "api"
  balancer-fqdn             = "api"
  vpc-id                    = "${aws_vpc.dmarc-env.id}"
  lb-subnet-ids             = "${join(",", aws_subnet.dmarc-env-subnet.*.id)}"
  instance-subnet-cidr      = "${join(",", values(var.zone-subnets))}"
  lb-internal               = "true"
  lb-target-count           = "8"
  lb-target-paths           = "aggregatereport,domainstatus,admin,metrics,reverse-dns,certificates,dkim,spf"
  lb-target-path-prefix     = "/api"
  health-check-grace-period = "300"
  aws-region                = "${var.aws-region}"
  env-name                  = "${var.env-name}"
  aws-account-id            = "${var.aws-account-id}"
  admin-subnets             = "${var.build-vpc == "" ? "" : var.build-vpc-cidr-block}"
  route53-zone-id           = "${aws_route53_zone.service-zone.id}"
  cloudwatch-alerts-sns-arn = "${aws_sns_topic.cloudwatch-alerts.arn}"
}
