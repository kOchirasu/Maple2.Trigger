namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2800 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2800, 2801, 2802, 2803, 2810, 2811, 2812, 2813, 2814, 2815, 2820, 2821, 2822, 2823, 2824, 2830, 2831, 2832, 2833, 2840, 2841, 2842, 2843, 2850, 2851, 2852, 2853, 2854, 2855, 2860, 2861, 2862, 2863, 2870, 2871, 2872, 2873, 2874, 2880, 2881, 2882, 2883, 2890, 2891, 2892, 2893}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {12800, 22800, 12810, 22810, 12820, 22820, 12830, 22830, 12840, 22840, 12850, 22850}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {92800})) {
                    return new State무너짐경고01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고01 : TriggerState {
            internal State무너짐경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52000014_QD__COLLAPSE_2800__0$", arg3: 4000, arg4: "0");
                context.SetEffect(arg1: new[] {12800, 22800}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2850, 2851, 2852, 2853, 2854, 2855}, arg2: false, arg3: 6, arg4: 0, arg5: 300);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {92801})) {
                    return new State무너짐경고02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고02 : TriggerState {
            internal State무너짐경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12810, 22810}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2860, 2861, 2862, 2863}, arg2: false, arg3: 4, arg4: 0, arg5: 200);
                context.SetRandomMesh(arg1: new[] {2800, 2801, 2802, 2803}, arg2: false, arg3: 4, arg4: 300, arg5: 400);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {92802})) {
                    return new State무너짐경고03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고03 : TriggerState {
            internal State무너짐경고03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12820, 22820}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2870, 2871, 2872, 2873, 2874}, arg2: false, arg3: 5, arg4: 0, arg5: 250);
                context.SetRandomMesh(arg1: new[] {2810, 2811, 2812, 2813, 2814, 2815}, arg2: false, arg3: 6, arg4: 300, arg5: 200);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {92803})) {
                    return new State무너짐경고04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고04 : TriggerState {
            internal State무너짐경고04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12830, 22830}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2880, 2881, 2882, 2883}, arg2: false, arg3: 4, arg4: 0, arg5: 300);
                context.SetRandomMesh(arg1: new[] {2820, 2821, 2822, 2823, 2824}, arg2: false, arg3: 5, arg4: 200, arg5: 300);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {92804})) {
                    return new State무너짐경고05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고05 : TriggerState {
            internal State무너짐경고05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12840, 22840}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2890, 2891, 2892, 2893}, arg2: false, arg3: 4, arg4: 0, arg5: 200);
                context.SetRandomMesh(arg1: new[] {2830, 2831, 2832, 2833}, arg2: false, arg3: 4, arg4: 300, arg5: 200);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    return new State무너짐경고06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고06 : TriggerState {
            internal State무너짐경고06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.SetEffect(arg1: new[] {12850, 22850}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2840, 2841, 2842, 2843}, arg2: false, arg3: 4, arg4: 100, arg5: 150);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12800, 22800, 12810, 22810, 12820, 22820, 12830, 22830, 12840, 22840, 12850, 22850}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}