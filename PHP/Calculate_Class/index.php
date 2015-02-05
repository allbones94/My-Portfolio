<?php require_once('class.calculate.php'); $val = new calculate() ?>
<!doctype html>
<head><title>PHP: Calculate Class</title></head>
<body>
<p><?php $val -> add(13,77)?></p>
<p><?php $val -> sub(20,45); ?></p>
<p><?php $val -> multi(12,11); ?></p>
<p><?php $val -> div(22,7); ?></p>
</body>
</html>