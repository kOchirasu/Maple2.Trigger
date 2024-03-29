namespace Maple2.Trigger._02010070_bf {
    public static class _main3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481, 490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508, 220, 221, 222, 223}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{3000});
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: false);
                context.SetEffect(triggerIds: new []{9000}, visible: false);
                context.SetSkill(triggerIds: new []{9001, 9002, 9003, 9004}, enabled: false);
                context.SetEffect(triggerIds: new []{95000, 95003, 95010, 95002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999994})) {
                    return new StateWaitTime안내01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime안내01 : TriggerState {
            internal StateWaitTime안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWaitTime안내02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime안내02 : TriggerState {
            internal StateWaitTime안내02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100703, textId: 20100703);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart1 : TriggerState {
            internal StateStart1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{3000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart2 : TriggerState {
            internal StateStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20100703);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{3000})) {
                    return new StateStart3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart3 : TriggerState {
            internal StateStart3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 88321, type: "trigger", code: "kakalfillusion");
                context.SetEffect(triggerIds: new []{9000}, visible: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20100704, textId: 20100704);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999995})) {
                    return new StateStart35(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart35 : TriggerState {
            internal StateStart35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02010070, portalId: 11);
                context.SetMesh(triggerIds: new []{220, 221, 222, 223}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart4(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(triggerIds: new []{100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class StateStart4 : TriggerState {
            internal StateStart4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{9000}, visible: false);
                context.SetSkill(triggerIds: new []{9001}, enabled: true);
                context.SetEffect(triggerIds: new []{95002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart5 : TriggerState {
            internal StateStart5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20100704);
                context.SetSkill(triggerIds: new []{9002}, enabled: true);
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart6 : TriggerState {
            internal StateStart6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{300, 301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355, 356, 357, 358, 359, 360, 361, 362, 363}, visible: true, arg3: 0, arg4: 50, arg5: 0f);
                context.SetMesh(triggerIds: new []{400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428}, visible: true, arg3: 0, arg4: 50, arg5: 0f);
                context.SetMesh(triggerIds: new []{430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458}, visible: true, arg3: 0, arg4: 50, arg5: 0f);
                context.SetSkill(triggerIds: new []{9003}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart7 : TriggerState {
            internal StateStart7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477, 478, 479, 480, 481}, visible: true, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(triggerIds: new []{490, 491, 492, 493, 494, 495, 496, 497, 498, 499, 500, 501, 502, 503, 504, 505, 506, 507, 508}, visible: true, arg3: 0, arg4: 200, arg5: 0f);
                context.SetEffect(triggerIds: new []{95003}, visible: true);
                context.SetSkill(triggerIds: new []{9004}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart8 : TriggerState {
            internal StateStart8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176, 177, 178, 179, 180, 181, 182, 183, 184, 185, 186, 187, 188, 189, 190, 191, 192, 193, 194, 195, 196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 211, 212, 213, 214, 215, 216, 217, 218, 219}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, script: "$02010070_BF__MAIN__5$", duration: 6000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{220, 221, 222, 223}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StatePCGetOut01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut01 : TriggerState {
            internal StatePCGetOut01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StatePCGetOut02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut02 : TriggerState {
            internal StatePCGetOut02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StatePCGetOut03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut03 : TriggerState {
            internal StatePCGetOut03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StatePCGetOut04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCGetOut04 : TriggerState {
            internal StatePCGetOut04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
