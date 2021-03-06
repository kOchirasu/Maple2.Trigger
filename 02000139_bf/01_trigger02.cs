namespace Maple2.Trigger._02000139_bf {
    public static class _01_trigger02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000160}, arg2: 1);
                context.SetLadder(arg1: 601, arg2: false, arg3: false);
                context.SetLadder(arg1: 602, arg2: false, arg3: false);
                context.SetLadder(arg1: 603, arg2: false, arg3: false);
                context.SetLadder(arg1: 604, arg2: false, arg3: false);
                context.SetLadder(arg1: 605, arg2: false, arg3: false);
                context.SetLadder(arg1: 606, arg2: false, arg3: false);
                context.SetLadder(arg1: 607, arg2: false, arg3: false);
                context.SetLadder(arg1: 608, arg2: false, arg3: false);
                context.SetLadder(arg1: 609, arg2: false, arg3: false);
                context.SetLadder(arg1: 610, arg2: false, arg3: false);
                context.SetLadder(arg1: 611, arg2: false, arg3: false);
                context.SetLadder(arg1: 612, arg2: false, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000160}, arg2: 0)) {
                    return new StateLadder(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder : TriggerState {
            internal StateLadder(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 601, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {701}, arg2: true);
                context.SetLadder(arg1: 602, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {702}, arg2: true);
                context.SetLadder(arg1: 603, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {703}, arg2: true);
                context.SetLadder(arg1: 604, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {704}, arg2: true);
                context.SetLadder(arg1: 605, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {705}, arg2: true);
                context.SetLadder(arg1: 606, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {706}, arg2: true);
                context.SetLadder(arg1: 607, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {707}, arg2: true);
                context.SetLadder(arg1: 608, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {708}, arg2: true);
                context.SetLadder(arg1: 609, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {709}, arg2: true);
                context.SetLadder(arg1: 610, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {710}, arg2: true);
                context.SetLadder(arg1: 611, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {711}, arg2: true);
                context.SetLadder(arg1: 612, arg2: true, arg3: true);
                context.SetEffect(arg1: new[] {713}, arg2: true);
                context.SetTimer(id: "4", arg2: 18);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}