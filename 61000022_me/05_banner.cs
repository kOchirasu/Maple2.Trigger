namespace Maple2.Trigger._61000022_me {
    public static class _05_banner {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {711, 712, 713, 714, 715, 701, 702, 703, 704, 705, 706, 707, 708, 709}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return new StateNextWait(context);
            }

            public override void OnExit() {
                context.SetUserValue(key: "SetBanner", value: 0);
            }
        }

        private class StateSetBanner : TriggerState {
            internal StateSetBanner(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BannerNumber") == 50) {
                    context.SetMesh(arg1: new[] {715}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 49) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 48) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 47) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 46) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 45) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 44) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 43) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 42) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 41) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 40) {
                    context.SetMesh(arg1: new[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 39) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 38) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 37) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 36) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 35) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 34) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 33) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 32) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 31) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 30) {
                    context.SetMesh(arg1: new[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 29) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 28) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 27) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 26) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 25) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 24) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 23) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 22) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 21) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 20) {
                    context.SetMesh(arg1: new[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 19) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 18) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 17) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 16) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 15) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 14) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 13) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 12) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 11) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 10) {
                    context.SetMesh(arg1: new[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 09) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 08) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 07) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 06) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 05) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 04) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 03) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 02) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 01) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 00) {
                    context.SetMesh(arg1: new[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(key: "SetBanner", value: 0);
            }
        }

        private class StateNextWait : TriggerState {
            internal StateNextWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SetBanner") == 1) {
                    return new StateSetBanner(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}