namespace Maple2.Trigger._61000022_me {
    public static class _05_banner {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{711, 712, 713, 714, 715, 701, 702, 703, 704, 705, 706, 707, 708, 709}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return new StateNextWait(context);
            }

            public override void OnExit() {
                context.SetUserValue(key: "SetBanner", value: 0);
            }
        }

        private class StateSetBanner : TriggerState {
            internal StateSetBanner(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{700, 701, 702, 703, 704, 705, 706, 707, 708, 709, 710, 711, 712, 713, 714, 715}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BannerNumber") == 50) {
                    context.SetMesh(triggerIds: new []{715}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 49) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{709}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 48) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{708}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 47) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{707}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 46) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{706}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 45) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{705}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 44) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{704}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 43) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{703}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 42) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{702}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 41) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{701}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 40) {
                    context.SetMesh(triggerIds: new []{714}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 39) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{709}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 38) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{708}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 37) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{707}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 36) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{706}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 35) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{705}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 34) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{704}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 33) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{703}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 32) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{702}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 31) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{701}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 30) {
                    context.SetMesh(triggerIds: new []{713}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 29) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{709}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 28) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{708}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 27) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{707}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 26) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{706}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 25) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{705}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 24) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{704}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 23) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{703}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 22) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{702}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 21) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{701}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 20) {
                    context.SetMesh(triggerIds: new []{712}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 19) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{709}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 18) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{708}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 17) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{707}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 16) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{706}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 15) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{705}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 14) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{704}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 13) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{703}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 12) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{702}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 11) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{701}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 10) {
                    context.SetMesh(triggerIds: new []{711}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 09) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{709}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 08) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{708}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 07) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{707}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 06) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{706}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 05) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{705}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 04) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{704}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 03) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{703}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 02) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{702}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 01) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{701}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    return new StateNextWait(context);
                }

                if (context.GetUserValue(key: "BannerNumber") == 00) {
                    context.SetMesh(triggerIds: new []{710}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.SetMesh(triggerIds: new []{700}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SetBanner") == 1) {
                    return new StateSetBanner(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
