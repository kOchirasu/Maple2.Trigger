namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2800 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2800, 2801, 2802, 2803, 2810, 2811, 2812, 2813, 2814, 2815, 2820, 2821, 2822, 2823, 2824, 2830, 2831, 2832, 2833, 2840, 2841, 2842, 2843, 2850, 2851, 2852, 2853, 2854, 2855, 2860, 2861, 2862, 2863, 2870, 2871, 2872, 2873, 2874, 2880, 2881, 2882, 2883, 2890, 2891, 2892, 2893}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{12800, 22800, 12810, 22810, 12820, 22820, 12830, 22830, 12840, 22840, 12850, 22850}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92800})) {
                    return new State무너짐경고01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고01 : TriggerState {
            internal State무너짐경고01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000014_QD__COLLAPSE_2800__0$", duration: 4000, boxId: 0);
                context.SetEffect(triggerIds: new []{12800, 22800}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2850, 2851, 2852, 2853, 2854, 2855}, visible: false, meshCount: 6, arg4: 0, delay: 300);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92801})) {
                    return new State무너짐경고02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고02 : TriggerState {
            internal State무너짐경고02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12810, 22810}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2860, 2861, 2862, 2863}, visible: false, meshCount: 4, arg4: 0, delay: 200);
                context.SetRandomMesh(triggerIds: new []{2800, 2801, 2802, 2803}, visible: false, meshCount: 4, arg4: 300, delay: 400);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92802})) {
                    return new State무너짐경고03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고03 : TriggerState {
            internal State무너짐경고03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12820, 22820}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2870, 2871, 2872, 2873, 2874}, visible: false, meshCount: 5, arg4: 0, delay: 250);
                context.SetRandomMesh(triggerIds: new []{2810, 2811, 2812, 2813, 2814, 2815}, visible: false, meshCount: 6, arg4: 300, delay: 200);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92803})) {
                    return new State무너짐경고04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고04 : TriggerState {
            internal State무너짐경고04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12830, 22830}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2880, 2881, 2882, 2883}, visible: false, meshCount: 4, arg4: 0, delay: 300);
                context.SetRandomMesh(triggerIds: new []{2820, 2821, 2822, 2823, 2824}, visible: false, meshCount: 5, arg4: 200, delay: 300);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92804})) {
                    return new State무너짐경고05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고05 : TriggerState {
            internal State무너짐경고05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12840, 22840}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2890, 2891, 2892, 2893}, visible: false, meshCount: 4, arg4: 0, delay: 200);
                context.SetRandomMesh(triggerIds: new []{2830, 2831, 2832, 2833}, visible: false, meshCount: 4, arg4: 300, delay: 200);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9003})) {
                    return new State무너짐경고06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐경고06 : TriggerState {
            internal State무너짐경고06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
                context.SetEffect(triggerIds: new []{12850, 22850}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2840, 2841, 2842, 2843}, visible: false, meshCount: 4, arg4: 100, delay: 150);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12800, 22800, 12810, 22810, 12820, 22820, 12830, 22830, 12840, 22840, 12850, 22850}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
