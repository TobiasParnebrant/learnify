import { Elements } from '@stripe/react-stripe-js';
import { loadStripe } from '@stripe/stripe-js';
import Checkout from '../Components/Checkout';

const stripePromise = loadStripe(
    "pk_test_51LlwtyLJ1eiUw1YvzIHJvU1b7VNGC8NVaI05XVaoPq6WaEykrGjkLe6I8sr9bs3Quu7pfi2uXM0ZV2ewKKds9Bu800nz6kDw7E"
);

export default function CheckoutPage() {
  return (
    <Elements stripe={stripePromise}>
      <Checkout />
    </Elements>
  );
}