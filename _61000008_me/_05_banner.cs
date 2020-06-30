using System;

namespace Maple2.Trigger._61000008_me {
    public static class _05_banner {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {711, 712, 713, 714, 715}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {701, 702, 703, 704, 705, 706, 707, 708, 709}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextWait(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(key: "SetBanner", value: 0);
            }
        }

        private class StateSetBanner : TriggerState {
            internal StateSetBanner(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715},
                    arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserValue(key: "BannerNumber", value: 50)) {
                    context.SetMesh(arg1: new int[] {715}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 49)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 48)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 47)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 46)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 45)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 44)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 43)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 42)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 41)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 40)) {
                    context.SetMesh(arg1: new int[] {714}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 39)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 38)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 37)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 36)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 35)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 34)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 33)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 32)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 31)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 30)) {
                    context.SetMesh(arg1: new int[] {713}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 29)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 28)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 27)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 26)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 25)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 24)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 23)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 22)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 21)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 20)) {
                    context.SetMesh(arg1: new int[] {712}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 19)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 18)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 17)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 16)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 15)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 14)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 13)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 12)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 11)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 10)) {
                    context.SetMesh(arg1: new int[] {711}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 09)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {709}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 08)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {708}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 07)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {707}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 06)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {706}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 05)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {705}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 04)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {704}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 03)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {703}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 02)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {702}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 01)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {701}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }

                if (context.UserValue(key: "BannerNumber", value: 00)) {
                    context.SetMesh(arg1: new int[] {710}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(arg1: new int[] {700}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new StateNextWait(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(key: "SetBanner", value: 0);
            }
        }

        private class StateNextWait : TriggerState {
            internal StateNextWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "SetBanner", value: 1)) {
                    context.State = new StateSetBanner(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}